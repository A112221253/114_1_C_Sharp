using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算平均」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 這裡可以加入計算平均分數的程式碼
            double test1, test2, test3;

            try
            {

                // 嘗試將輸入的文字轉換為數字
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算平均分數
                double average = (test1 + test2 + test3) / 3.0;

                // 顯示平均分數，格式化為兩位小數
                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                // 如果輸入格式錯誤，顯示錯誤訊息
                MessageBox.Show(ex.Message, "例外發生!");
                // 清除三個成績輸入框與平均分數顯示標籤的內容
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";
                // 將焦點設回第一個成績輸入框，方便使用者重新輸入
                test1TextBox.Focus();
            }
        }

        // 當使用者點擊「清除」按鈕時觸發
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入框與平均分數顯示標籤的內容
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            // 將焦點設回第一個成績輸入框，方便使用者重新輸入
            test1TextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（結束程式）
            this.Close();
        }

        // 當使用者點擊平均分數顯示標籤時觸發（目前未使用）
        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
