namespace logInpage
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if ((UserNametextBox.Text == "wisal") && (PasswordtextBox.Text == "wisal123"))
            {
                this.Hide();
                DashBoard d1 = new DashBoard();
                d1.Show();
            }
            else
            {
                MessageBox.Show("incorrect userName or passcode");
                UserNametextBox.Clear();
                PasswordtextBox.Clear();
                UserNametextBox.Focus();
                
            }
        }
    }
}