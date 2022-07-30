namespace _18_SimpleApp_Move_cursor_toNextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // this the one way ,but this way to make the method and write code there 
        //    if(e.KeyCode == Keys.Enter)
        //    {
        //        this.SelectNextControl(NametextBox, true, true, true, true);
        //    }
        //}
    }

        private void Enter_key(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        }
    }