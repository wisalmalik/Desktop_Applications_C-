namespace _06_simpleApp_openForm_oneTo_another
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            f2.Show();
        }
    }
}