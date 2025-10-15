using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件
            InitializeComponent();
            this.exitButton.Font = new System.Drawing.Font("新細明體", 22F);
this.clearButton.Font = new System.Drawing.Font("新細明體", 22F);
this.calculateButton.Font = new System.Drawing.Font("新細明體", 22F);
this.grossPayLabel.Font = new System.Drawing.Font("新細明體", 22F);
this.outputDescriptionLabel.Font = new System.Drawing.Font("新細明體", 22F);
this.hourlyPayRateTextBox.Font = new System.Drawing.Font("新細明體", 22F);
this.hoursWorkedTextBox.Font = new System.Drawing.Font("新細明體", 22F);
this.hourlyPayRatePromptLabel.Font = new System.Drawing.Font("新細明體", 22F);
this.hoursWorkedPromptLabel.Font = new System.Drawing.Font("新細明體", 22F);
        }

        // 當使用者點擊「計算總薪資」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 基本工時（超過此工時才算加班）
            const decimal BASE_HOURS = 40m;
            // 加班時薪倍率
            const decimal OT_MUTIPLIER = 1.5m;

            decimal hoursWorked;      // 實際工作時數
            decimal hourlyPayRate;    // 時薪
            decimal grossPay;         // 總薪資

            try
            {
                // 取得使用者輸入的工時與時薪，並轉換為 decimal 型別
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // 判斷是否有加班
                if (hoursWorked <= BASE_HOURS)
                {
                    // 未超過基本工時，直接以時薪計算
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    // 超過基本工時，計算加班薪資
                    grossPay = (BASE_HOURS * hourlyPayRate) +
                               ((hoursWorked - BASE_HOURS) * hourlyPayRate * OT_MUTIPLIER);
                }
                // 將計算結果以貨幣格式顯示在標籤上
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch(Exception ex)
            {
                // 若輸入格式錯誤，顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者點擊「清除」按鈕時執行
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空所有輸入欄位與結果標籤
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點移回工時輸入欄位
            hoursWorkedTextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
