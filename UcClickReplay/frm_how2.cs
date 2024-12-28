using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcClickReplay
{
    public partial class frm_how2 : Form
    {
        public frm_how2()
        {
            InitializeComponent();

        }

        private void frm_how2_Load(object sender, EventArgs e)
        {
            txt_how2.Text = "・マウス操作登録をクリックすると操作対象のディスプレイにグレーのフィルタがかかります。" + Environment.NewLine 
                            + "　その状態で操作したい座標をクリックすることで登録できます。" + Environment.NewLine;
            txt_how2.Text += "・データ読み込みボタンをクリックし、入力させたいデータを含むCSV形式のファイルを読み込ませます。" + Environment.NewLine
                            + "　値の入力をクリックすると、マウスカーソルがある位置に対して、CSV内容を入力するイベントを挿入できます。" + Environment.NewLine
                            + "　値の入力１回目：CSV１列目、値の入力２回目：CSV２列目...という順に入力されます。" + Environment.NewLine
                            + "　２週目に入ると２行目のデータが読み込まれます。" + Environment.NewLine;
            txt_how2.Text += "・CSVの入力をしている場合はCSVのデータが無くなると処理が終了します。" + Environment.NewLine + "　";
        }
    }
}
