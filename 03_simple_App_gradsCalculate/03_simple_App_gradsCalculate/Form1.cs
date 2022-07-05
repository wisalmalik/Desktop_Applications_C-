namespace _03_simple_App_gradsCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int marks = Convert.ToInt32 (textBox1.Text);

            if(marks <= 50)
            {
                MessageBox.Show("you are fail");
            }
            else if(marks > 50 && marks <= 60)
            {
                MessageBox.Show("You got D grad");
            }
            else if(marks > 60 && marks <= 70)
            {
                MessageBox.Show("You got C grad");

            }
            else if (marks > 70 && marks <= 80)
            {
                MessageBox.Show("you got B grad");
            }
            else if(marks > 80 && marks <= 90)
            {
                MessageBox.Show("you got A grad");

            }
            else if(marks > 90 && marks <= 100)
            {
                MessageBox.Show("you got A+ grad");
            }
            else if(marks > 100){
                MessageBox.Show("unvaild value");
            }
        }
    }
}