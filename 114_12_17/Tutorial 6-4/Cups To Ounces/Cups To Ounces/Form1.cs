using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CupsToOunces 方法接受一個杯數參數，並回傳相等的液體盎司數。
        // 例如：傳入 1（杯）會回傳 8（盎司）。
     

        private void convertButton_Click(object sender, EventArgs e)
        {
           double cups;       // 儲存杯數
           double ounces;    // 儲存盎司數
         
           if (double.TryParse(cupsTextBox.Text, out cups))
           {
               // 呼叫 CupsToOunces 方法
               ounces = CupsToOunces(cups);
               // 顯示結果
               ouncesLabel.Text = ounces.ToString("F2") + "盎司";
           }
           else
           {
               // 顯示錯誤訊息
               MessageBox.Show("請輸入有效的數字。", "輸入錯誤",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private double CupsToOunces(double cups)
        {
           return cups * 8.0;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
