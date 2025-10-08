using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;
        const decimal TWENTYFIVE_CENTS = 25.0m;
        const decimal FIFTY_CENTS = 50.0m;


        private decimal total;
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊 5 分硬幣圖片時觸發的事件處理函式
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 這裡可以加入累加 5 分金額的程式碼
            total += 5;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊 10 分硬幣圖片時觸發的事件處理函式
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 這裡可以加入累加 10 分金額的程式碼
            total += 10;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊 25 分硬幣圖片時觸發的事件處理函式
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 這裡可以加入累加 25 分金額的程式碼
            total += 25;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊 50 分硬幣圖片時觸發的事件處理函式
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 這裡可以加入累加 50 分金額的程式碼
            total += 50;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊「離開」按鈕時觸發的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
