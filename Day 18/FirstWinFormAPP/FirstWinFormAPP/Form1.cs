namespace FirstWinFormAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = textBox1.Text;
            string pwd = textBox2.Text;

            if (uName == "Nikhil" && pwd == "Pass@1234")
            {
                MessageBox.Show(" Welcome " + uName);
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
