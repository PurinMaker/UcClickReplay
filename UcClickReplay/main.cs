using System.Text;
using System.Runtime.InteropServices;

namespace UcClickReplay
{
    public partial class main : Form
    {
        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void SetCursorPos(int X, int Y);
        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [StructLayout(LayoutKind.Sequential)]

        struct click_event
        {
            public int x;
            public int y;
            public string nevent;
            public int idx;
        };

        List<click_event> levents = new List<click_event>();
        string[] _lsbuf = null;
        static public int xpos = 0;
        static public int ypos = 0;
        bool flg_cancel = false;
        CancellationTokenSource tokenSource;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            UpdateStatus("[*]停止中");
        }

        private void btn_add_clk_Click(object sender, EventArgs e)
        {
            click_event _cbuf = new click_event();
            System.Drawing.Rectangle rect = System.Windows.Forms.Screen.FromPoint(Cursor.Position).Bounds;
            PointCatcher _frm2 = new PointCatcher();
            _frm2.Size = new System.Drawing.Size(rect.Width, rect.Height);
            _frm2.Location = new Point(0, 0);
            if (_frm2.ShowDialog() == DialogResult.OK)
            {
                _cbuf.nevent = "click";
                _cbuf.x = xpos;
                _cbuf.y = ypos;
                lst_commands.Items.Add("クリック：X " + xpos.ToString() + ", Y " + ypos.ToString());
                levents.Add(_cbuf);
            }
        }
        private void bth_readdata_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_val.Text = "";
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                byte[] _buf = new byte[fs.Length];
                fs.Read(_buf, 0, _buf.Length);
                fs.Close();
                string _sbuf = Encoding.UTF8.GetString(_buf);
                _lsbuf = _sbuf.Split("\n");
                for (int i = 0; i < _lsbuf.Length; i++)
                {
                    txt_val.Text += _lsbuf[i] + Environment.NewLine;
                }
            }
        }

        private void btn_add_delay_Click(object sender, EventArgs e)
        {
            click_event _cbuf = new click_event();
            _cbuf.nevent = "delay";
            _cbuf.x = int.Parse(txt_ms.Text);
            lst_commands.Items.Add("ディレイ：" + txt_ms.Text + "ms");
            levents.Add(_cbuf);
        }
        private void btn_add_val_Click(object sender, EventArgs e)
        {
            click_event _cbuf = new click_event();
            _cbuf.nevent = "valent";
            lst_commands.Items.Add("値の入力");
            levents.Add(_cbuf);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            levents = new List<click_event>();
            lst_commands.Items.Clear();
        }

        private void UpdateStatus(string _status)
        {
            tsp_status.Text = _status;
            Application.DoEvents();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            UpdateStatus("[*]実行中");
            ClickWorker();
            //tokenSource = new CancellationTokenSource();
            //var token = tokenSource.Token;
            //var task = Task.Run(() => ClickWorker(token));
        }

        private void ClickWorker()
        {
            flg_cancel = false;
            int _index = 0;
            int _insvalpos = 0;
            bool flg_end = false;
            int _loopcnt = int.Parse(txt_itr.Text);
            while (true)
            {
                if (flg_end || (_loopcnt <= _index)||flg_cancel)
                    break;
                _insvalpos = 0;
                System.Threading.Thread.Sleep(2000);
                for (int i = 0; i < levents.Count; i++)
                {
                    Application.DoEvents();
                    if (_lsbuf != null && _index == _lsbuf.Length)
                    {
                        flg_end = true;
                        break;
                    }
                    switch (levents[i].nevent)
                    {
                        case "click":
                            SetCursorPos(levents[i].x, levents[i].y);
                            mouse_event(0x02, 0, 0, 0, 0);
                            mouse_event(0x04, 0, 0, 0, 0);
                            break;
                        case "valent":
                            string[] _llsbuf = _lsbuf[_index].Split(",");
                            SendKeys.Send(_llsbuf[_insvalpos]);
                            SendKeys.Send("{ENTER}");
                            
                            _insvalpos++;
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case "delay":
                            System.Threading.Thread.Sleep(levents[i].x);
                            break;
                        default:
                            break;
                    }

                    System.Threading.Thread.Sleep(1000);
                }
                _index++;
            }
            UpdateStatus("[*]停止中");
        }

        async Task ClickWorker(CancellationToken token)
        {

            int _index = 0;
            int _insvalpos = 0;
            bool flg_end = false;
            int _loopcnt = int.Parse(txt_itr.Text);
            while (true)
            {
                if (flg_end || (_loopcnt <= _index) || token.IsCancellationRequested)
                {
                    UpdateStatus("[*]停止中(Cancel)");
                    break;
                }
                _insvalpos = 0;
                System.Threading.Thread.Sleep(1000);
                for (int i = 0; i < levents.Count; i++)
                {
                    if (_lsbuf != null && _index == _lsbuf.Length)
                    {
                        flg_end = true;
                        break;
                    }

                    switch (levents[i].nevent)
                    {
                        case "click":
                            SetCursorPos(levents[i].x, levents[i].y);
                            mouse_event(0x02, 0, 0, 0, 0);
                            mouse_event(0x04, 0, 0, 0, 0);
                            break;
                        case "valent":
                            string[] _llsbuf = _lsbuf[_index].Split(",");
                            SynchronizationContext.Current?.Send(_ =>{ SendKeys.Send(_llsbuf[_insvalpos]); SendKeys.Send("{ENTER}"); },null);
                            
                            
                            _insvalpos++;
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case "delay":
                            System.Threading.Thread.Sleep(levents[i].x);
                            break;
                        default:
                            break;
                    }

                    System.Threading.Thread.Sleep(500);
                }
                _index++;
            }
            UpdateStatus("[*]停止中");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (tokenSource != null)
            {
                tokenSource.Cancel();
                UpdateStatus("[*]停止中(Cancel)");
            } else if (!flg_cancel) {
                flg_cancel = true;
            }
        }

        private void tsp_how2_Click(object sender, EventArgs e)
        {
            frm_how2 frm_howtouse = new frm_how2();
            frm_howtouse.ShowDialog();
        }

        private void tsp_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsp_config_Click(object sender, EventArgs e)
        {

        }
        private void tsp_readcommand_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    byte[] _configbuf = new byte[fs.Length];
                    string _configdata;
                    fs.Read(_configbuf, 0, _configbuf.Length);
                    _configdata = Encoding.UTF8.GetString(_configbuf);
                    string[] _lconfigdata = _configdata.Split("--");

                    foreach (string s in _lconfigdata)
                    {
                        var _confline = s.Split(":");
                        string _value;
                        if (_confline.Length != 2)
                            continue;
                        else
                        {
                            _value = Encoding.UTF8.GetString(Convert.FromBase64String(_confline[1]));

                        }

                        switch (_confline[0])
                        {
                            case "LST":
                                var _lvalue = _value.Split(Environment.NewLine);
                                lst_commands.Items.Clear();
                                foreach (var item in _lvalue)
                                {
                                    if (item == null || item == "")
                                        continue;
                                    lst_commands.Items.Add(item);
                                }
                                break;
                            case "LEVT":
                                var _levalue = _value.Split(Environment.NewLine);
                                levents = new List<click_event>();
                                foreach (var item in _levalue)
                                {
                                    click_event _bufevent = new click_event();
                                    var _eventvals = item.Split(",");
                                    if (_eventvals.Length != 4)
                                        continue;
                                    _bufevent.x = int.Parse(_eventvals[0]);
                                    _bufevent.y = int.Parse(_eventvals[1]);
                                    _bufevent.nevent = _eventvals[2];
                                    _bufevent.idx = int.Parse(_eventvals[3]);
                                    levents.Add(_bufevent);
                                }
                                break;
                            case "LBUF":
                                var _lbuf = _value.Split(Environment.NewLine);
                                _lsbuf = new string[_lbuf.Length];
                                for (int i = 0; i < _lbuf.Length; i++)
                                {
                                    if (_lbuf[i] == "" || _lbuf[i] == null)
                                        continue;
                                    _lsbuf[i] = _lbuf[i];
                                }
                                break;
                            case "LTBOX":
                                txt_val.Text = _value;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }
        private void stp_saveconf_Click(object sender, EventArgs e)
        {
            string _savedata = "--LST:";
            string _buf = "";
            foreach (var item in lst_commands.Items)
            {
                _buf += item.ToString()+Environment.NewLine;
            }            
            _savedata += Convert.ToBase64String(Encoding.UTF8.GetBytes(_buf)) + Environment.NewLine;

            _savedata += "--LEVT:";
            _buf = "";
            foreach (var item in levents)
            {
                _buf += item.x.ToString() + "," + item.y.ToString() + "," + item.nevent + "," + item.idx.ToString()+Environment.NewLine;
            }
            _savedata += Convert.ToBase64String(Encoding.UTF8.GetBytes(_buf)) + Environment.NewLine;

            _savedata += "--LBUF:";
            _buf = "";
            foreach (var item in _lsbuf)
            {
                _buf += item + Environment.NewLine;
            }
            _savedata += Convert.ToBase64String(Encoding.UTF8.GetBytes(_buf)) + Environment.NewLine;

            _savedata += "--LTBOX:";
            _savedata += Convert.ToBase64String(Encoding.UTF8.GetBytes(txt_val.Text)) + Environment.NewLine;

            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    fs.Write(Encoding.ASCII.GetBytes(_savedata), 0, _savedata.Length);

                }
                MessageBox.Show("設定ファイルの保存が完了しました");
            }
        }
    }
}
