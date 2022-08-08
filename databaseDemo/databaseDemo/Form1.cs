using System.Data.SqlClient;


namespace databaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. adress of sql server and database
            
            string connectionString = "Data Source=DESKTOP-6SRQP85\\SQL_SERVER_DEV;Initial Catalog=studentinformation;Integrated Security=True";

            // 2. establish connection

           SqlConnection con = new SqlConnection(connectionString);

            //open connection
            con.Open();
            // 4. prepare query
            string Name = nametextBox.Text;
            int id = Int32.Parse( idtextBox.Text);
            string fathername = FathernametextBox.Text;
            int number = Int32.Parse( NumbertextBox.Text);
            String email = EmailtextBox.Text;
            string Query = "insert into studentinfo(studentName, studentid, faterName, number, email) values('"+Name+"', "+id+", '"+fathername+"', "+number+", '"+email+"')";


            // 5. ececute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            // 6. close connection
            con.Close();
            MessageBox.Show("Data has been save");

        }
    }
}