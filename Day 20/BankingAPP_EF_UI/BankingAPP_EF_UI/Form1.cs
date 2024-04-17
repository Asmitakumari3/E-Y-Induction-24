using BankingAPP_EF_UI.Database;
namespace BankingAPP_EF_UI
{
    public partial class Form1 : Form
    {
        //global variable
        BankingDbEfContext db = new BankingDbEfContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountsInfo newAccObj = new AccountsInfo()
            {
                AccNo = Convert.ToInt32(textBox1.Text),
                AccName = textBox2.Text,
                AccType = comboBox1.Text,
                AccBalance = Convert.ToInt64(textBox3.Text),
                AccBranch = Convert.ToInt32(textBox4.Text)
            };
            if (radioButton1.Checked)
            {
                newAccObj.AccIsActive = true;
            }
            else
            {
                newAccObj.AccIsActive = false;
            }

            db.AccountsInfos.Add(newAccObj);
            db.SaveChanges();

            //this is equal to console.writeline("Account created");
            MessageBox.Show("Account Created");
        }
        AccountsInfo accToUpdate;
        private void button2_Click(object sender, EventArgs e)
        {
            //var accToUpdate = (from a in db.AccountsInfos
            //                   where a.AccNo == Convert.ToInt32(textBox1.Text)
            //                   select a).Single();

            if (accToUpdate != null)
            {
                accToUpdate.AccName = textBox2.Text;
                accToUpdate.AccType = comboBox1.Text;
                accToUpdate.AccBalance = Convert.ToInt64(textBox3.Text);
                accToUpdate.AccBranch = Convert.ToInt32(textBox4.Text);
                if (radioButton1.Checked)
                {
                    accToUpdate.AccIsActive = true;
                }
                else
                {
                    accToUpdate.AccIsActive = false;
                }
                MessageBox.Show("Account Updated Successfully");
            }
            else
            {
                MessageBox.Show("Invalid Account Number");
            }

            db.SaveChanges();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                accToUpdate = (from a in db.AccountsInfos
                               where a.AccNo == Convert.ToInt32(textBox1.Text)
                               select a).Single();
                textBox2.Text = accToUpdate.AccName;
                textBox3.Text = accToUpdate.AccBalance.ToString();
                textBox4.Text = accToUpdate.AccBranch.ToString();
                comboBox1.Text = accToUpdate.AccType;

                if (accToUpdate.AccIsActive == true)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = false;
                }
            }
            catch (Exception es)
            {

                MessageBox.Show("Account Not Found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var accToDelete = (from a in db.AccountsInfos
                               where a.AccNo == Convert.ToInt32(textBox1.Text)
                               select a).Single();

            if (accToDelete != null)
            {
                db.AccountsInfos.Remove(accToDelete);
                db.SaveChanges();
                MessageBox.Show("Account Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Account Not Found");
            }







        }
    }
}

