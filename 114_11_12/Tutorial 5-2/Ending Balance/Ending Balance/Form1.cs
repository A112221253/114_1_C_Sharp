using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單與元件
        // 這裡會呼叫 Designer 產生的 InitializeComponent 方法
        // InitializeComponent 會建立並設定所有控制項（Text、Font 等）
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕的事件處理程序
        // TODO: 在此加入計算邏輯，例如：
        // 1. 從 startingBalTextBox 讀取起始餘額（字串轉數值並處理格式錯誤）
        // 2. 從 monthsTextBox 讀取月份數量（字串轉整數並驗證範圍）
        // 3. 根據商業邏輯逐月計算並將明細加入 detailListBox
        // 4. 計算最終結餘並顯示於 endingBalanceLabel
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // 每月利率為 0.5%

            decimal startingBalance;
            int months;
            int count = 1;

            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                   while (count <= months)
                   {
                        // 計算每月結餘
                        startingBalance *=  (1+INTEREST_RATE);

                        // 將每月結餘加入明細清單
                        detailListBox.Items.Add("第 " +  count + "個月結餘: " + startingBalance.ToString("c"));
                        count++;
                    }
                    // 計算最終結餘
                    endingBalanceLabel.Text = startingBalance.ToString("C2");
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量（正整數）。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。", "輸入錯誤");
            }
        }

        // 清除按鈕的事件處理程序
        // 功能：
        // - 清除起始餘額與月份輸入欄位的內容
        // - 清除結餘顯示控制項（endingBalanceLabel）
        // - 清空明細清單（detailListBox）
        // - 將輸入焦點重設到起始餘額輸入欄位（startingBalTextBox）
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes、結餘顯示標籤，以及 ListBox。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設焦點至起始餘額輸入欄位
            startingBalTextBox.Focus();
        }

        // 離開按鈕的事件處理程序
        // 功能：關閉表單並結束應用程式（若為單一視窗應用）
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void monthsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startingBalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
