using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NhanVien
{
    public partial class frmDelay : Form
    {
        Random rand = new Random();
        int star = 5;
        public frmDelay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            StringFormat format = new StringFormat();
            Font font = new Font("Arial", 45);
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString("Ẩm Thực Chay Huệ Tâm", font, Brushes.Purple, ClientRectangle, format);
            for (int i = 0; i <= star; i++)
            {
                int x = rand.Next(0, ClientRectangle.Width);
                int y = rand.Next(0, ClientRectangle.Height);
                Color color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                SolidBrush br = new SolidBrush(color);
                int n = rand.Next(2, 10);
                g.FillEllipse(br, x, y, n, n);
            }
            g.Dispose();
            this.Opacity -= 0.013;
            if (this.Opacity <= 0)
            {
                timer1.Enabled = false;
                MainFrm f = new MainFrm();
                f.ShowDialog();
                this.Close();
            }
        }

        private void frmDelay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            //if(timer1.Enabled == false)
            //{
            //    MainFrm f = new MainFrm();
            //    f.Show();
            //    this.Close();
            //}
        }
    }
}
