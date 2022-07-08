namespace _05_simple_app_enum
{
    public partial class Form1 : Form
    {
        //gobal veriable declearation
        private int OperatorInteger = 1;
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int firstnumber = int.Parse(textBox1.Text);
            int secondnumber = int.Parse(textBox2.Text);
           
            if (OperatorInteger == 1)
            {
                 result = firstnumber + secondnumber;
            }
            if(OperatorInteger == 2)
            {
                result = firstnumber - secondnumber;
            }
            if(OperatorInteger == 3)
            {
                result = firstnumber / secondnumber;
            }
            if(OperatorInteger == 4)
            {
                result = firstnumber * secondnumber;
            }
            MessageBox.Show("Result = " + result , "result window"+MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if commit some changes in a futur then we don't know that what is operatorinteger we declear by itself
            // so the better solution is to use the enum
            OperatorInteger = (int)(mathoperation.Add);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperatorInteger = (int)(mathoperation.subtraction);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperatorInteger = (int)(mathoperation.multiply);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OperatorInteger = (int)(mathoperation.divide);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}