using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH8_8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDrawText_Click(object sender, EventArgs e)
        {
            FormDrawText f = new FormDrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawImage_Click(object sender, EventArgs e)
        {
            FormDrawImage f = new FormDrawImage();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawWithMouse_Click(object sender, EventArgs e)
        {
            FormDrawWithMouse f = new FormDrawWithMouse();
            f.MdiParent = this;
            f.Show();
        }
    }
}
