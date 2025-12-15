using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Eight of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Two of Clubs";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "King of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Ace of Spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Black Joker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
