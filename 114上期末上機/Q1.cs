using System;
using System.Windows.Forms;
using System.Drawing;

namespace RPSGame
{
    public partial class Form1 : Form
    {
        // 出拳列舉：更清楚好維護
        private enum Hand
        {
            Stone = 0,
            Paper = 1,
            Scissor = 2
        }

        private readonly Random _rng = new Random();
        private int _playerWinCount = 0;
        private int _computerWinCount = 0;

        public Form1()
        {
            InitializeComponent();

            // 表單載入時清空（也可以在 Form1_Load 做）
            ClearImagesAndResult();

            // 如果你不想在設計器手動綁事件，可用程式綁定：
            // stoneButton.Click += stoneButton_Click;
            // paperButton.Click += paperButton_Click;
            // scissorButton.Click += scissorButton_Click;
            // exitButton.Click += exitButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearImagesAndResult();
        }

        // 1) 電腦隨機出拳
        private Hand GetCompChoice()
        {
            int value = _rng.Next(0, 3); // 0~2
            return (Hand)value;
        }

        // 2) 顯示電腦圖片
        private void ShowComputerImage(Hand comp)
        {
            computerPictureBox.Image = GetImageByHand(comp);
        }

        // 3) 顯示玩家圖片
        private void ShowPlayerImage(Hand player)
        {
            playerPictureBox.Image = GetImageByHand(player);
        }

        // 4) 判斷勝負 + 累計 + 顯示結果
        private void ShowWinner(Hand player, Hand comp)
        {
            // 平手
            if (player == comp)
            {
                resultLabel.Text = "平手！";
                return; // 平手不加分
            }

            bool playerWin =
                (player == Hand.Stone && comp == Hand.Scissor) ||
                (player == Hand.Scissor && comp == Hand.Paper) ||
                (player == Hand.Paper && comp == Hand.Stone);

            if (playerWin)
            {
                _playerWinCount++;
                resultLabel.Text = "你贏了！";
            }
            else
            {
                _computerWinCount++;
                resultLabel.Text = "電腦贏了！";
            }
        }

        // 共同流程：玩家出拳 -> 電腦出拳 -> 顯示圖 -> 顯示結果
        private void PlayRound(Hand playerChoice)
        {
            Hand compChoice = GetCompChoice();

            ShowPlayerImage(playerChoice);
            ShowComputerImage(compChoice);

            ShowWinner(playerChoice, compChoice);
        }

        // 取得對應圖片（若你圖片資源名稱不同，這裡改掉即可）
        private Image GetImageByHand(Hand hand)
        {
            switch (hand)
            {

                case Hand.Stone:
                    return Resources.stone;
                case Hand.Paper:
                    return Resources.paper;
                case Hand.Scissor:
                    return Resources.scissor;
                default:
                    return null;
            }
        }

        // 清空圖片與結果
        private void ClearImagesAndResult()
        {
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            resultLabel.Text = "";
        }

        // 事件處理：三個按鈕
        private void stoneButton_Click(object sender, EventArgs e)
        {
            PlayRound(Hand.Stone);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            PlayRound(Hand.Paper);
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            PlayRound(Hand.Scissor);
        }

        // 結束遊戲：顯示統計 + 關閉
        private void exitButton_Click(object sender, EventArgs e)
        {
            string msg = "遊戲結束！\n\n" +
                         $"玩家贏：{_playerWinCount} 次\n" +
                         $"電腦贏：{_computerWinCount} 次\n\n" +
                         "確認後關閉程式。";

            MessageBox.Show(msg, "統計結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void computerPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

