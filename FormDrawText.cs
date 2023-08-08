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
    public partial class FormDrawText : Form
    {
        String sText = "HELLO";
        public FormDrawText()
        {
            InitializeComponent();
        }

        private void FormDrawText_Load(object sender, EventArgs e)
        {
            
        }

        private void FormDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font fnt = new Font("Arial", 36, FontStyle.Bold);
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(sText, fnt, Brushes.Green,ClientRectangle ,fmt);

            //
            Image img = Image.FromFile("rose.png");
            TextureBrush tbr = new TextureBrush(img);
            fmt.LineAlignment = StringAlignment.Far;
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(sText, fnt, tbr, ClientRectangle, fmt);

            //
            HatchBrush hbr = new HatchBrush(HatchStyle.Cross, Color.Red, Color.Yellow);
            fmt.FormatFlags = StringFormatFlags.DirectionVertical;
            fmt.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString(sText, fnt, hbr, ClientRectangle, fmt);

            //
            LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(0, 0, 10, 10), Color.DarkBlue, Color.White,45);
            fmt.Alignment = StringAlignment.Far;
            fmt.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString(sText, fnt, lgb, ClientRectangle, fmt);
        }

        private void FormDrawText_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
