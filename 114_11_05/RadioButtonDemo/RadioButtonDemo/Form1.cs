using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容: ";
            String drink = "";
            String sandwich = "";

            if (coffeeradioButton.Checked)
            {
                drink = "咖啡 ";
            }
            else if (milktearadioButton.Checked)
            {
                drink = "奶茶 ";
            }
            else if (blacktearadioButton.Checked)
            {
                drink = "紅茶 ";
            }
            else if (juiceradioButton.Checked)
            {
                drink = "果汁 ";
            }
            else
            {
                drink = "";
            }
            if (tunaradioButton.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else if (hamradioButton.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else if (jellyradioButton.Checked)
            {
                sandwich = "果醬三明治 ";
            }
            else
            {
                sandwich = "";
            }

            message += drink + sandwich;
            MessageBox.Show(message, " 您的點餐內容");
        }

        private void leavebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
