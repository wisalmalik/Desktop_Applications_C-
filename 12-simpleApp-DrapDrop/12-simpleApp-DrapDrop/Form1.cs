namespace _12_simpleApp_DrapDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            // this line of code till us that what effect is created,
            e.Effect = DragDropEffects.Copy;
            //what add in the textbox1.Text -> add the text in the  box 
            textBox1.Text  = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}