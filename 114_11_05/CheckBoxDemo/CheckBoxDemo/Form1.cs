using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "";

            if (checkBox1.Checked)
            {
                message = message + "夏威夷\n ";
            }
            if (checkBox2.Checked)
            {
                message = message + "章魚燒\n ";
            }
            if (checkBox3.Checked)
            {
                message = message + "綜合海鮮\n ";
            }
            if (checkBox4.Checked)
            {
                message = message + "義式火腿\n ";
            }
            if (message == "")
            {
                message = "您尚未選擇";
            }

            MessageBox.Show(message, "您選擇的披薩口味是");
        }
    }
}
