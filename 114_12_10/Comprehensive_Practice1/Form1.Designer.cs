namespace Comprehensive_Practice1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.Label lblQuiz1;
        private System.Windows.Forms.Label lblQuiz2;
        private System.Windows.Forms.Label lblQuiz3;

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.TextBox txtQuiz3;

        private System.Windows.Forms.Button btnShowHighest;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblResult;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.lblQuiz1 = new System.Windows.Forms.Label();
            this.lblQuiz2 = new System.Windows.Forms.Label();
            this.lblQuiz3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.txtQuiz3 = new System.Windows.Forms.TextBox();
            this.btnShowHighest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSurname.Location = new System.Drawing.Point(20, 18);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 55);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "姓";
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGivenName.Location = new System.Drawing.Point(451, 21);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(68, 55);
            this.lblGivenName.TabIndex = 2;
            this.lblGivenName.Text = "名";
            // 
            // lblQuiz1
            // 
            this.lblQuiz1.AutoSize = true;
            this.lblQuiz1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuiz1.Location = new System.Drawing.Point(2, 89);
            this.lblQuiz1.Name = "lblQuiz1";
            this.lblQuiz1.Size = new System.Drawing.Size(138, 55);
            this.lblQuiz1.TabIndex = 4;
            this.lblQuiz1.Text = "小考1";
            // 
            // lblQuiz2
            // 
            this.lblQuiz2.AutoSize = true;
            this.lblQuiz2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuiz2.Location = new System.Drawing.Point(2, 154);
            this.lblQuiz2.Name = "lblQuiz2";
            this.lblQuiz2.Size = new System.Drawing.Size(138, 55);
            this.lblQuiz2.TabIndex = 6;
            this.lblQuiz2.Text = "小考2";
            // 
            // lblQuiz3
            // 
            this.lblQuiz3.AutoSize = true;
            this.lblQuiz3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuiz3.Location = new System.Drawing.Point(2, 233);
            this.lblQuiz3.Name = "lblQuiz3";
            this.lblQuiz3.Size = new System.Drawing.Size(138, 55);
            this.lblQuiz3.TabIndex = 8;
            this.lblQuiz3.Text = "小考3";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSurname.Location = new System.Drawing.Point(130, 14);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(240, 66);
            this.txtSurname.TabIndex = 1;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGivenName.Location = new System.Drawing.Point(548, 18);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(240, 66);
            this.txtGivenName.TabIndex = 3;
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuiz1.Location = new System.Drawing.Point(146, 86);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(240, 66);
            this.txtQuiz1.TabIndex = 5;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuiz2.Location = new System.Drawing.Point(146, 158);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(240, 66);
            this.txtQuiz2.TabIndex = 7;
            // 
            // txtQuiz3
            // 
            this.txtQuiz3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuiz3.Location = new System.Drawing.Point(146, 230);
            this.txtQuiz3.Name = "txtQuiz3";
            this.txtQuiz3.Size = new System.Drawing.Size(240, 66);
            this.txtQuiz3.TabIndex = 9;
            // 
            // btnShowHighest
            // 
            this.btnShowHighest.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowHighest.Location = new System.Drawing.Point(12, 326);
            this.btnShowHighest.Name = "btnShowHighest";
            this.btnShowHighest.Size = new System.Drawing.Size(255, 56);
            this.btnShowHighest.TabIndex = 10;
            this.btnShowHighest.Text = "顯示最高分";
            this.btnShowHighest.UseVisualStyleBackColor = true;
            this.btnShowHighest.Click += new System.EventHandler(this.btnShowHighest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(481, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 56);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(392, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(380, 120);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblGivenName);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.lblQuiz1);
            this.Controls.Add(this.txtQuiz1);
            this.Controls.Add(this.lblQuiz2);
            this.Controls.Add(this.txtQuiz2);
            this.Controls.Add(this.lblQuiz3);
            this.Controls.Add(this.txtQuiz3);
            this.Controls.Add(this.btnShowHighest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

