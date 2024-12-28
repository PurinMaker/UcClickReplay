namespace UcClickReplay
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_add_clk = new Button();
            bth_readdata = new Button();
            btn_add_val = new Button();
            groupBox1 = new GroupBox();
            btn_add_delay = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txt_ms = new TextBox();
            label3 = new Label();
            txt_val = new TextBox();
            label4 = new Label();
            txt_itr = new TextBox();
            button5 = new Button();
            btn_execute = new Button();
            lst_commands = new ListBox();
            label5 = new Label();
            fileFToolStripMenuItem = new ToolStripMenuItem();
            tsp_readcommand = new ToolStripMenuItem();
            stp_saveconf = new ToolStripMenuItem();
            tsp_quit = new ToolStripMenuItem();
            helpHToolStripMenuItem = new ToolStripMenuItem();
            tsp_how2 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            tsp_status = new ToolStripStatusLabel();
            btn_cancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(249, 15);
            label1.TabIndex = 2;
            label1.Text = "コマンド一覧 ※複数ディスプレイには未対応です・・・";
            // 
            // btn_add_clk
            // 
            btn_add_clk.BackColor = SystemColors.ActiveCaption;
            btn_add_clk.Location = new Point(604, 56);
            btn_add_clk.Name = "btn_add_clk";
            btn_add_clk.Size = new Size(113, 28);
            btn_add_clk.TabIndex = 3;
            btn_add_clk.Text = "マウス操作登録";
            btn_add_clk.UseVisualStyleBackColor = false;
            btn_add_clk.Click += btn_add_clk_Click;
            // 
            // bth_readdata
            // 
            bth_readdata.Location = new Point(15, 46);
            bth_readdata.Name = "bth_readdata";
            bth_readdata.Size = new Size(113, 28);
            bth_readdata.TabIndex = 4;
            bth_readdata.Text = "データ読み込み";
            bth_readdata.UseVisualStyleBackColor = true;
            bth_readdata.Click += bth_readdata_Click;
            // 
            // btn_add_val
            // 
            btn_add_val.BackColor = SystemColors.ActiveCaption;
            btn_add_val.Location = new Point(15, 12);
            btn_add_val.Name = "btn_add_val";
            btn_add_val.Size = new Size(113, 28);
            btn_add_val.TabIndex = 5;
            btn_add_val.Text = "値の入力";
            btn_add_val.UseVisualStyleBackColor = false;
            btn_add_val.Click += btn_add_val_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bth_readdata);
            groupBox1.Controls.Add(btn_add_val);
            groupBox1.Location = new Point(589, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 81);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btn_add_delay
            // 
            btn_add_delay.BackColor = SystemColors.ActiveCaption;
            btn_add_delay.Location = new Point(15, 22);
            btn_add_delay.Name = "btn_add_delay";
            btn_add_delay.Size = new Size(113, 28);
            btn_add_delay.TabIndex = 7;
            btn_add_delay.Text = "ディレイの挿入";
            btn_add_delay.UseVisualStyleBackColor = false;
            btn_add_delay.Click += btn_add_delay_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_ms);
            groupBox2.Controls.Add(btn_add_delay);
            groupBox2.Location = new Point(589, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(141, 92);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 60);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 9;
            label2.Text = "ms";
            // 
            // txt_ms
            // 
            txt_ms.Location = new Point(22, 56);
            txt_ms.Name = "txt_ms";
            txt_ms.Size = new Size(70, 23);
            txt_ms.TabIndex = 8;
            txt_ms.Text = "1000";
            txt_ms.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 283);
            label3.Name = "label3";
            label3.Size = new Size(317, 15);
            label3.TabIndex = 9;
            label3.Text = "変数一覧(データ読み込みからＣＳＶ形式で読み込ませて下さい)";
            // 
            // txt_val
            // 
            txt_val.BackColor = Color.LightCyan;
            txt_val.Location = new Point(16, 301);
            txt_val.Multiline = true;
            txt_val.Name = "txt_val";
            txt_val.Size = new Size(557, 119);
            txt_val.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(604, 271);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "ループ数";
            // 
            // txt_itr
            // 
            txt_itr.Location = new Point(608, 289);
            txt_itr.Name = "txt_itr";
            txt_itr.Size = new Size(109, 23);
            txt_itr.TabIndex = 10;
            txt_itr.Text = "100";
            txt_itr.TextAlign = HorizontalAlignment.Right;
            // 
            // button5
            // 
            button5.BackColor = Color.Plum;
            button5.Location = new Point(604, 318);
            button5.Name = "button5";
            button5.Size = new Size(113, 28);
            button5.TabIndex = 10;
            button5.Text = "コマンドクリア";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btn_execute
            // 
            btn_execute.BackColor = SystemColors.ButtonHighlight;
            btn_execute.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_execute.Location = new Point(604, 352);
            btn_execute.Name = "btn_execute";
            btn_execute.Size = new Size(113, 36);
            btn_execute.TabIndex = 10;
            btn_execute.Text = "実行";
            btn_execute.UseVisualStyleBackColor = false;
            btn_execute.Click += btn_execute_Click;
            // 
            // lst_commands
            // 
            lst_commands.FormattingEnabled = true;
            lst_commands.ItemHeight = 15;
            lst_commands.Location = new Point(16, 45);
            lst_commands.Name = "lst_commands";
            lst_commands.Size = new Size(557, 229);
            lst_commands.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 423);
            label5.Name = "label5";
            label5.Size = new Size(321, 15);
            label5.TabIndex = 13;
            label5.Text = "※変数がある場合は変数の行数分処理を実行した後終了します。";
            // 
            // fileFToolStripMenuItem
            // 
            fileFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsp_readcommand, stp_saveconf, tsp_quit });
            fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            fileFToolStripMenuItem.Size = new Size(51, 20);
            fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // tsp_readcommand
            // 
            tsp_readcommand.Name = "tsp_readcommand";
            tsp_readcommand.Size = new Size(146, 22);
            tsp_readcommand.Text = "コマンド読込(&L)";
            tsp_readcommand.Click += tsp_readcommand_Click;
            // 
            // stp_saveconf
            // 
            stp_saveconf.Name = "stp_saveconf";
            stp_saveconf.Size = new Size(146, 22);
            stp_saveconf.Text = "コマンド保存(&S)";
            stp_saveconf.Click += stp_saveconf_Click;
            // 
            // tsp_quit
            // 
            tsp_quit.Name = "tsp_quit";
            tsp_quit.Size = new Size(146, 22);
            tsp_quit.Text = "終了(&Q)";
            tsp_quit.Click += tsp_quit_Click;
            // 
            // helpHToolStripMenuItem
            // 
            helpHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsp_how2 });
            helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            helpHToolStripMenuItem.Size = new Size(61, 20);
            helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // tsp_how2
            // 
            tsp_how2.Name = "tsp_how2";
            tsp_how2.Size = new Size(141, 22);
            tsp_how2.Text = "使用方法(&M)";
            tsp_how2.Click += tsp_how2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileFToolStripMenuItem, helpHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(742, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsp_status });
            statusStrip1.Location = new Point(0, 445);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(742, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsp_status
            // 
            tsp_status.Name = "tsp_status";
            tsp_status.Size = new Size(118, 17);
            tsp_status.Text = "toolStripStatusLabel1";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.ButtonHighlight;
            btn_cancel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_cancel.Location = new Point(604, 394);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(113, 32);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "キャンセル";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 467);
            Controls.Add(btn_cancel);
            Controls.Add(statusStrip1);
            Controls.Add(label5);
            Controls.Add(lst_commands);
            Controls.Add(btn_execute);
            Controls.Add(button5);
            Controls.Add(txt_itr);
            Controls.Add(label4);
            Controls.Add(txt_val);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_add_clk);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "main";
            Text = "UnClickReplay v0.0.1";
            Load += main_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_add_clk;
        private Button bth_readdata;
        private Button btn_add_val;
        private GroupBox groupBox1;
        private Button btn_add_delay;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txt_ms;
        private Label label3;
        private TextBox txt_val;
        private Label label4;
        private TextBox txt_itr;
        private Button button5;
        private Button btn_execute;
        private ListBox lst_commands;
        private Label label5;
        private ToolStripMenuItem fileFToolStripMenuItem;
        private ToolStripMenuItem tsp_readcommand;
        private ToolStripMenuItem tsp_quit;
        private ToolStripMenuItem helpHToolStripMenuItem;
        private ToolStripMenuItem tsp_how2;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsp_status;
        private Button btn_cancel;
        private ToolStripMenuItem stp_saveconf;
    }
}
