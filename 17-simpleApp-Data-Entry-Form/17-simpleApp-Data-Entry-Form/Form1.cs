namespace _17_simpleApp_Data_Entry_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            // this if condation check the condtion of the textbox if empty then show the messagebox 
            if(NametextBox.Text == "")
            {
                MessageBox.Show("Name is reuired","validation Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //if the nametextbox is empty then it show only name error not the recorde error
                
                NametextBox.BackColor = Color.LightPink;
                NametextBox.Focus();
                return;
            }
            if (AgetextBox.Text == "")
            {
                MessageBox.Show("Age is reuired", "validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if the nametextbox is empty then it show only name error not the recorde error

                AgetextBox.BackColor = Color.LightPink;
                AgetextBox.Focus();
                return;
            }
            else
            {
                if(!int.TryParse(AgetextBox.Text, out int age))
                {
                    MessageBox.Show("Enter the integer", "validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AgetextBox.BackColor = Color.LightPink;
                    AgetextBox.Focus();
                    return;
                }

            }
                
            
            MessageBox.Show("You record added successfully " , "Recorded Added");
        }

        private void QualificationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QualificationcomboBox.Text == "Msc")
            {
                QualificationcomboBox.BackColor = Color.Red;
            }
            if (QualificationcomboBox.Text == "Bsc")
            {
                QualificationcomboBox.BackColor = Color.BlueViolet;
            }
            if (QualificationcomboBox.Text == "BA")
            {
                QualificationcomboBox.BackColor = Color.Pink;
            }
            if (QualificationcomboBox.Text == "MA")
            {
                QualificationcomboBox.BackColor = Color.Yellow;
            }
            if (QualificationcomboBox.Text == "MS")
            {
                QualificationcomboBox.BackColor = Color.Green;
            }
            
        

        }

        private void AgetextBox_TextChanged(object sender, EventArgs e)
        {
            AgetextBox.BackColor = Color.White;
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            NametextBox.BackColor= Color.White;
        }
    }
}