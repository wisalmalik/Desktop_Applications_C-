using System.IO;
namespace _20_SimpleApp_SaveUserName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this line the code check the username and password
            if(usernamebox.Text == "admin" && Passwordbox.Text == "password")
            {
                //if the username and password are correct then it create the  file in the bin folder 

                using (StreamWriter streamwriter = new StreamWriter("username.txt"))
                {
                    //read the text from the usertextbox
                    streamwriter.WriteLine(usernamebox.Text);
                }

                this.Hide();

                Form2 f2 = new Form2();
                f2.Visible = true;
            }
            else
            {
                MessageBox.Show("the user name or password are wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                usernamebox.Clear();
                Passwordbox.Clear();    
                usernamebox.Focus();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this code is inplment in the form 
            // this line of code read the username for the username.txt file 
            if (File.Exists("username.Txt")){
                using (StreamReader streamReader = new StreamReader("username.Txt"))
                {
                    usernamebox.Text = streamReader.ReadLine();
                }
            }


        }
    }
}