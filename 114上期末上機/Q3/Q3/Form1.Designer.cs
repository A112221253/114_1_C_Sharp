namespace LotteryApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblCompareTitle = new System.Windows.Forms.Label();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblN1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblN1.Location = new System.Drawing.Point(2, 54);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(130, 64);
            this.lblN1.TabIndex = 0;
            this.lblN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN2
            // 
            this.lblN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblN2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblN2.Location = new System.Drawing.Point(171, 54);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(130, 64);
            this.lblN2.TabIndex = 1;
            this.lblN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN3
            // 
            this.lblN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblN3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblN3.Location = new System.Drawing.Point(328, 54);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(130, 64);
            this.lblN3.TabIndex = 2;
            this.lblN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN4
            // 
            this.lblN4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblN4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblN4.Location = new System.Drawing.Point(504, 54);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(130, 64);
            this.lblN4.TabIndex = 3;
            this.lblN4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN5
            // 
            this.lblN5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblN5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblN5.Location = new System.Drawing.Point(658, 54);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(130, 64);
            this.lblN5.TabIndex = 4;
            this.lblN5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerate.Location = new System.Drawing.Point(89, 176);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(177, 63);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "產生號碼";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpen.Location = new System.Drawing.Point(309, 176);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(179, 63);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "開獎號碼";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(544, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 63);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(35, 266);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 144);
            this.listBox1.TabIndex = 8;
            // 
            // lblCompareTitle
            // 
            this.lblCompareTitle.AutoSize = true;
            this.lblCompareTitle.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompareTitle.ForeColor = System.Drawing.Color.Red;
            this.lblCompareTitle.Location = new System.Drawing.Point(498, 266);
            this.lblCompareTitle.Name = "lblCompareTitle";
            this.lblCompareTitle.Size = new System.Drawing.Size(159, 36);
            this.lblCompareTitle.TabIndex = 9;
            this.lblCompareTitle.Text = "比對結果";
            // 
            // lblMatchCount
            // 
            this.lblMatchCount.AutoSize = true;
            this.lblMatchCount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMatchCount.ForeColor = System.Drawing.Color.Red;
            this.lblMatchCount.Location = new System.Drawing.Point(544, 317);
            this.lblMatchCount.Name = "lblMatchCount";
            this.lblMatchCount.Size = new System.Drawing.Size(176, 36);
            this.lblMatchCount.TabIndex = 10;
            this.lblMatchCount.Text = "中0個號碼";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrize.ForeColor = System.Drawing.Color.Red;
            this.lblPrize.Location = new System.Drawing.Point(536, 381);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(123, 36);
            this.lblPrize.TabIndex = 11;
            this.lblPrize.Text = "沒中獎";
            this.lblPrize.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblMatchCount);
            this.Controls.Add(this.lblCompareTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblN5);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblCompareTitle;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblPrize;
    }
}

