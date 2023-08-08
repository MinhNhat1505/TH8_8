using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TH8_8
{
    public partial class FormDrawWithMouse : Form
    {
        int penWidth;
        Point pOld;
        Color penColor;
        Bitmap btmp;
        public FormDrawWithMouse()
        {
            InitializeComponent();
        }

        private void FormDrawWithMouse_Load(object sender, EventArgs e)
        {
            penWidth = 1;
            penColor = Color.Red;
            btmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void FormDrawWithMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(btmp, 0, 0);
        }

        private void FormDrawWithMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FormDrawWithMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(penColor,penWidth);
                //cho dau but chi tron
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(btmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        //Neu dung su kien keydown thi no se bat o FormMain => Override 
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.R:
                    penColor = Color.Red;
                    break;
                case Keys.G:
                    penColor = Color.Green;
                    break;
                case Keys.B:
                    penColor = Color.Blue;
                    break;
                case Keys.Up:
                    if (penWidth < 50)
                        penWidth++;
                    break;
                case Keys.Down:
                    if (penWidth > 1)
                        penWidth--;
                    break;
            }
            return true;
        }
    }
}
