using System.Data;
using System.Data.SqlClient;
namespace EmpManagement_SQL_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=EmployeeManagementDB;integrated security=true");
            SqlCommand cmd_newEmp = new SqlCommand("insert into employeeInfo values(@eNo,@eNm,@eDesig,@eDept,@eSal,@eIsActive)", con);

            cmd_newEmp.Parameters.AddWithValue("@eNo", textBox1.Text);
            cmd_newEmp.Parameters.AddWithValue("@eNm", textBox2.Text);
            cmd_newEmp.Parameters.AddWithValue("@eDesig", comboBox1.Text);
            cmd_newEmp.Parameters.AddWithValue("@eDept", textBox3.Text);
            cmd_newEmp.Parameters.AddWithValue("@eSal", textBox4.Text);
            if(radioButton1.Checked)
            {
                cmd_newEmp.Parameters.AddWithValue("@eIsActive",1);
                comboBox1.Text = "";
                radioButton1.Checked = false;
            }
            else
            {
                cmd_newEmp.Parameters.AddWithValue("@eIsActive", 0);
            }

            con.Open();
          int rows =  cmd_newEmp.ExecuteNonQuery();
                
            con.Close();
            

        }
    }
}