using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算每加侖英里數」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告公里數、油量（公升）、每公升公里數變數
            double kilometers; // 行駛公里數
            double liters;     // 使用油量（公升）
            double kmpl;       // 每公升可行駛公里數

            // 取得使用者輸入的公里數與公升數，並轉為 double
            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);

            // 計算每公升可行駛公里數
            kmpl = kilometers / liters;

            // 顯示計算結果，格式為「n2」並加上單位
            mpgLabel.Text = kmpl.ToString("n2") + " 公里/公升";
        }

        // 當使用者點擊「離開」按鈕時觸發，關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}
