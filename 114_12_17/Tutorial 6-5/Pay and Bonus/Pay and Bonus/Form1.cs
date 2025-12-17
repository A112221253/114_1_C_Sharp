using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
           decimal grossPay;
            decimal bonus;
           decimal contribution;

           if (InputIsValid(out grossPay, out bonus))
           {
               // Calculate the contribution.
               contribution = (grossPay + bonus) * CONTRIB_RATE;
               // Display the contribution.
               contributionLabel.Text = 
                   "The contribution is: " + contribution.ToString("c");
           }
           else
           {
               // Display an error message.
               MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
            }
        }


        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {
            bool inputisValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if(decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputisValid = true;
                }
                else
                {
                   MessageBox.Show("獎金輸入無效。", "輸入錯誤");
                   inputisValid = false;
                }
            }
            else
            {
                MessageBox.Show("總薪資輸入無效。", "輸入錯誤");
               bonus = 0;
            }
            return inputisValid;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
