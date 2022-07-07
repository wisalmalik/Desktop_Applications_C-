namespace _04_simpleApp_data_Collection_print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double basic_insurance = 50.5;

            int age = int.Parse(AgeBox.Text);
            if (age > 30)
            {
                basic_insurance += 50;
            }
            else
            {
                basic_insurance += 100;
            }
            string country = CountrycomboBox.Text;

            if (country == "Pakistan" || country == "india" || country == "turkey" || country == "afghastan")
            {
                basic_insurance += 40;
            }
            else
            {
                basic_insurance += 50;
            }
            if (permiuminsuranceYesradioButton.Checked)
            {
                basic_insurance += 100;
            }
            else if (permiuminsuranceNoradioButton4.Checked)
            {
                basic_insurance += 0;
            }
            if (NoclaimdiscountYesradioButton.Checked)
            {
                basic_insurance  -= 25;
            }
            if (NoclaimdiscountNoradioButton.Checked)
            {
                basic_insurance += 50;
            }
            if (sickcoverYesradioButton.Checked)
            {
                basic_insurance += 50;
            }
            if (sickcoverNoradioButton.Checked)
            {
                basic_insurance += 0;
            }

            totalpermiumlabel.Text = "$" + basic_insurance;
        }

    }
}