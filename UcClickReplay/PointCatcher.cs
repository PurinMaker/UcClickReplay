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
    public partial class PointCatcher : Form
    {
        public PointCatcher()
        {
            InitializeComponent();
        }

        private void PointCatcher_Load(object sender, EventArgs e)
        {

        }

        private void PointCatcher_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            UcClickReplay.main.xpos = e.Location.X;
            UcClickReplay.main.ypos = e.Location.Y;
            Close();
        }
    }
}
