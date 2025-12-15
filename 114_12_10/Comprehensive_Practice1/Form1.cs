using System;
using System.Windows.Forms;

namespace Comprehensive_Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowHighest_Click(object sender, EventArgs e)
        {
            string surname = txtSurname.Text.Trim();
            string givenName = txtGivenName.Text.Trim();
            int q1, q2, q3;
            if (int.TryParse(txtQuiz1.Text.Trim(), out q1) &&
                int.TryParse(txtQuiz2.Text.Trim(), out q2) &&
                int.TryParse(txtQuiz3.Text.Trim(), out q3))
            {
                showResult(surname, givenName, q1, q2, q3);
            }
            else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤");
            } }
            private void showResult(string surname, string givenName, int q1, int q2, int q3)
            {
            int highestScore;
            if (q1 >= q2 && q1 >= q3)
            {
                highestScore = q1;
                
            }
            else if (q2 >= q1 && q2 >= q3)
            {
                highestScore = q2;
                
            }
            else
            {
                highestScore = q3;
                
            }
            lblResult.Text = string.Format("{0}{1}的最高成績{2}分", givenName, surname, highestScore);
            }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
