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
using System.Threading;

namespace Friend_File
{
    public partial class Form1 : Form
    {

        private int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            try
            {
                outputFile = File.AppendText("Friends.txt");
                outputFile.WriteLine(count + ": " + nameTextBox.Text);
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
