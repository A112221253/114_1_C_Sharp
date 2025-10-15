using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 當使用者點擊「審核資格」按鈕時觸發
        /// 這裡可加入貸款資格審核的邏輯
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MINIMUN_SALARY = 1200000m; // 最低年薪門檻
            const int MINIMUN_YEARS = 2; // 最低現職年資門檻

            decimal salary; // 使用者輸入的年薪
            int yearsOnJob; // 使用者輸入的現職年資


            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);


                if (salary >= MINIMUN_SALARY )
                {
                    if (yearsOnJob >= MINIMUN_YEARS)
                    {
                        decisionLabel.Text = "符合資格";
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格：年資未達最低標準";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格：年資未達最低標準";
                }
            }
            catch (Exception ex)
            {
                // 捕捉格式錯誤例外，提示使用者輸入有效的數字
                MessageBox.Show(ex.Message);
            }
            // 可根據輸入的年薪與年資進行資格判斷
        }

        /// <summary>
        /// 當使用者點擊「清除」按鈕時觸發
        /// 清空所有輸入欄位與結果顯示，並將游標移至年薪輸入框
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與年資輸入框，以及審核結果標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標移至年薪輸入框，方便使用者繼續輸入
            salaryTextBox.Focus();
        }

        /// <summary>
        /// 當使用者點擊「離開」按鈕時觸發
        /// 關閉整個表單（程式結束）
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
                    
        }
    }
}
