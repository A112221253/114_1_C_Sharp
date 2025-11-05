using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;

            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city)
                {
                    case "丹佛":
                        timeZoneLabel.Text = "山地標準時區";
                        break;
                    case "檀香山":
                        timeZoneLabel.Text = "夏威夷標準時區";
                        break;
                    case "明尼阿波利斯":
                        timeZoneLabel.Text = "中部標準時區";
                        break;
                    case "紐約":
                        timeZoneLabel.Text = "東部標準時區";
                        break;
                    case "舊金山":
                        timeZoneLabel.Text = "太平洋標準時區";
                        break;
                }
            }
            else
            {
                MessageBox.Show("請選擇一個城市");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
