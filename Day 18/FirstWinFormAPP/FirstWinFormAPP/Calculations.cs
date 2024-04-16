using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormAPP
{
    public partial class Calculations : Form
    {
        public Calculations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox2.Text);
            int num2 = Convert.ToInt32(textBox3.Text);

            if(comboBox1.Text == "Add")
            {
                MessageBox.Show("Addition " + (num1 + num2));
            }
            if (comboBox1.Text == "Subtract")
            {
                MessageBox.Show("Subtraction " + (num1 - num2));
            }
            if (comboBox1.Text == "Multiply")
            {
                MessageBox.Show("Multiplication " + (num1 * num2));
            }
            if (comboBox1.Text == "Divide")
            {
                MessageBox.Show("Division " + (num1 / num2));
            }
        }
    }
}
