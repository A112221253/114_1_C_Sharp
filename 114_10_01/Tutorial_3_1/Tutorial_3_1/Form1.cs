using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_1
{
    // Form1 類別，繼承自 Windows Form，為主視窗
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的控制項
        }

        // label2 的 Click 事件處理函式（目前未實作任何功能）
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // showDatebutton 的 Click 事件處理函式
        // 當使用者按下顯示日期按鈕時，會執行此方法
        private void showDatebutton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的星期幾
            string dayOfWeek = dayOfWeekTextbox.Text;
            // 取得使用者輸入的月份
            string month = MonthTextbox.Text;
            // 取得使用者輸入的年份
            string year = yearTextbox.Text;
            // 取得使用者輸入的日期（幾號）
            string dayOfMonth = dayOfMonthTextbox.Text;

            // 組合成中華民國日期格式的字串
            string output = "中華民國 " + year + "年" + month + "月" + dayOfMonth + "日" + ", 星期 " + dayOfWeek;

            // 將組合好的日期字串顯示在 dateOutputLabel 上
            dateOutputLabel.Text = output;
        }

        // exitbutton 的 Click 事件處理函式
        // 當使用者按下離開按鈕時，關閉視窗
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉目前的表單
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextbox.Text = "";
            MonthTextbox.Text = "";
            dayOfMonthTextbox.Text = "";
            yearTextbox.Text = "";
            dateOutputLabel.Text = "";
        }
    }
}
