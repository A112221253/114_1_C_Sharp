using System;
using System.IO;
using System.Windows.Forms;

namespace LotteryApp
{
    public partial class Form1 : Form
    {
        // 5個使用者號碼、5個開獎號碼
        int[] userNums = new int[5];
        int[] winNums = new int[5];

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            InitUIState();
        }

        // 初始化：一開始不給開獎（因為還沒產生號碼）
        private void InitUIState()
        {
            btnOpen.Enabled = false;

            // 先把上面5格清空
            ClearUserNumberBoxes();

            // 清空結果區
            listBox1.Items.Clear();
            lblMatchCount.Text = "中0個號碼";
            lblPrize.Text = "";
        }

        // 清空上面 5 格號碼
        private void ClearUserNumberBoxes()
        {
            lblN1.Text = "";
            lblN2.Text = "";
            lblN3.Text = "";
            lblN4.Text = "";
            lblN5.Text = "";
        }

        // ============ 1) 產生號碼 ============
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 產生 5 個 1~49 不重複號碼（用陣列 + for + if 判斷）
            for (int i = 0; i < 5; i++)
            {
                int n;
                bool repeat;

                do
                {
                    n = rnd.Next(1, 50); // 1~49
                    repeat = false;

                    // 檢查是否重複：只跟前面已經產生的比
                    for (int j = 0; j < i; j++)
                    {
                        if (userNums[j] == n)
                        {
                            repeat = true;
                            break;
                        }
                    }

                } while (repeat);

                userNums[i] = n;
            }

            // 顯示到 5 格
            lblN1.Text = userNums[0].ToString();
            lblN2.Text = userNums[1].ToString();
            lblN3.Text = userNums[2].ToString();
            lblN4.Text = userNums[3].ToString();
            lblN5.Text = userNums[4].ToString();

            // 產生完才允許開獎讀檔比對
            btnOpen.Enabled = true;

            // 清空上次開獎與結果（避免混淆）
            listBox1.Items.Clear();
            lblMatchCount.Text = "中0個號碼";
            lblPrize.Text = "";
        }

        // ============ 2) 開獎號碼(讀檔) ============
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文字檔 (*.txt)|*.txt";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                listBox1.Items.Clear();

                // 用 StreamReader 讀檔
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        string line = sr.ReadLine();

                        // 1) 行數不足
                        if (line == null)
                            throw new Exception("檔案行數不足，必須剛好 5 行。");

                        // 2) 不是數字會在這裡爆掉
                        int num = int.Parse(line.Trim());

                        // 3) 範圍驗證 1~49
                        if (num < 1 || num > 49)
                            throw new Exception("號碼必須在 1~49 範圍內。");

                        // 4) 開獎號碼也不能重複（可加分）
                        for (int j = 0; j < i; j++)
                        {
                            if (winNums[j] == num)
                                throw new Exception("開獎號碼重複，請檢查檔案。");
                        }

                        winNums[i] = num;
                        listBox1.Items.Add($"第{i + 1}個號碼：{num}");
                    }

                    // 5) 如果檔案還有第6行，代表格式不對（可加分）
                    if (sr.ReadLine() != null)
                        throw new Exception("檔案行數過多，必須剛好 5 行。");
                }

                // 讀完立刻比對
                CompareNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀檔錯誤：" + ex.Message);
            }
        }

        // ============ 3) 比對邏輯 ============
        private void CompareNumbers()
        {
            int match = 0;

            // userNums 的每個數字，去 winNums 找是否存在
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (userNums[i] == winNums[j])
                    {
                        match++;
                        break;
                    }
                }
            }

            lblMatchCount.Text = $"中{match}個號碼";

            // 獎項文字（你也可以依老師規格改）
            if (match == 0)
                lblPrize.Text = "😢 沒中獎";
            else if (match == 1)
                lblPrize.Text = "🙂 小獎";
            else if (match == 2)
                lblPrize.Text = "😀 普通獎";
            else if (match == 3)
                lblPrize.Text = "🎉 大獎";
            else if (match == 4)
                lblPrize.Text = "🏆 特獎";
            else
                lblPrize.Text = "🔥 你中頭獎了！";
        }
        private void label3_Click(object sender, EventArgs e)
        {
            // 什麼都不做
        }

        // ============ 4) 離開 ============
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

