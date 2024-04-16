using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FirstWinFormAPP
{
    public partial class MyNotePad : Form
    {
        public MyNotePad()
        {
            InitializeComponent();
        }


        FileStream myFile;
        StreamReader read;
        StreamWriter write;

        private void MyNotePad_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            myFile = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
            write = new StreamWriter(myFile);
            write.WriteLine(richTextBox1.Text);

            write.Close();
            myFile.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPrivewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            myFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            read = new StreamReader(myFile);
            richTextBox1.Text = read.ReadToEnd();

            read.Close();
            myFile.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}



