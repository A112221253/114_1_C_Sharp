using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double fuelEconomy;

            if (double.TryParse(milesTextBox.Text, out kms) )
            {
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    // 計算每加侖英里數。
                    // Calculate miles per gallon.
                    fuelEconomy = kms / liters;
                    mpgLabel.Text = fuelEconomy.ToString("n2") + "公里/公升";
                }
            }
            else
            {
                // 顯示錯誤訊息。
                // Display an error message.
                MessageBox.Show("請輸入有效的公里數值");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（結束應用程式視窗）。
            // Close the form.
            this.Close();
        }
    }
}
