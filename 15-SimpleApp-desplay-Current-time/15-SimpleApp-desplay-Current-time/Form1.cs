namespace _15_SimpleApp_desplay_Current_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int label1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToLongDateString();
        }
    }
}