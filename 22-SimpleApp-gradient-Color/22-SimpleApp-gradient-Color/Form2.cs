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

namespace _21_SimpleApp_gradient_Color
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgrphic = e.Graphics;
            Pen pen = new(Color.FromArgb(24, 40, 72), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(24, 40, 72), Color.FromArgb(130, 122, 255), LinearGradientMode.Vertical);
            mgrphic.FillRectangle(lgb, area);
            mgrphic.DrawRectangle(pen, area);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = false;
            f2.ShowDialog();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {
           // groupBox.BackColor = Color.Transparent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
