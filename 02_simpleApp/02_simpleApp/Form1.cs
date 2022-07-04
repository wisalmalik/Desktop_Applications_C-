using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_simpleApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // in this we cover sting into int

            int firstnumber = Convert.ToInt32(FirstNumber.Text);
            int secondnumber = Convert.ToInt32(SecondNumber.Text);

            // condition where the radio button is checked then run the following codition
            int Resultnum = 0;
            if ( AddationRadionButton.Checked == true)
            {
                Resultnum = firstnumber + secondnumber;
            }
            if ( SubtractionRadioButton.Checked == true)
            {
                Resultnum = firstnumber - secondnumber;
            }
            // the show the result in the result box 
            // tosting mean that int conver into string
            Resulttextbox.Text = Resultnum.ToString(); 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //this is called run time design 

            FirstNumber.Clear();
            SecondNumber.Clear();
            Resulttextbox.Clear();

            // to checked the radion button 
            AddationRadionButton.Checked = true ;

            // this is fouce on the first box
            FirstNumber.Focus();
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
