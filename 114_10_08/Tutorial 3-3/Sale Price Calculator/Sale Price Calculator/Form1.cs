using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算特價」按鈕時觸發此事件
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告變數：原價、折扣百分比、特價
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

        
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);


            // 計算特價
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            // 顯示特價，格式化為貨幣形式
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者點擊「離開」按鈕時觸發此事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // 當原價文字方塊內容變更時觸發此事件
        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // 可於此處加入輸入驗證或其他相關處理
        }
    }
}
