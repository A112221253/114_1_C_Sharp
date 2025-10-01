namespace Tutorial_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayOfWeekTextbox = new System.Windows.Forms.TextBox();
            this.MonthTextbox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextbox = new System.Windows.Forms.TextBox();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDatebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(114, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(162, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "月：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(162, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(162, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "年：";
            // 
            // dayOfWeekTextbox
            // 
            this.dayOfWeekTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfWeekTextbox.Location = new System.Drawing.Point(298, 60);
            this.dayOfWeekTextbox.Name = "dayOfWeekTextbox";
            this.dayOfWeekTextbox.Size = new System.Drawing.Size(369, 65);
            this.dayOfWeekTextbox.TabIndex = 4;
            // 
            // MonthTextbox
            // 
            this.MonthTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthTextbox.Location = new System.Drawing.Point(298, 146);
            this.MonthTextbox.Name = "MonthTextbox";
            this.MonthTextbox.Size = new System.Drawing.Size(369, 65);
            this.MonthTextbox.TabIndex = 5;
            // 
            // dayOfMonthTextbox
            // 
            this.dayOfMonthTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfMonthTextbox.Location = new System.Drawing.Point(298, 232);
            this.dayOfMonthTextbox.Name = "dayOfMonthTextbox";
            this.dayOfMonthTextbox.Size = new System.Drawing.Size(369, 65);
            this.dayOfMonthTextbox.TabIndex = 6;
            // 
            // yearTextbox
            // 
            this.yearTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearTextbox.Location = new System.Drawing.Point(298, 316);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(369, 65);
            this.yearTextbox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOutputLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateOutputLabel.Location = new System.Drawing.Point(45, 414);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(721, 95);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDatebutton
            // 
            this.showDatebutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showDatebutton.Location = new System.Drawing.Point(45, 532);
            this.showDatebutton.Name = "showDatebutton";
            this.showDatebutton.Size = new System.Drawing.Size(208, 65);
            this.showDatebutton.TabIndex = 9;
            this.showDatebutton.Text = "顯示日期";
            this.showDatebutton.UseVisualStyleBackColor = true;
            this.showDatebutton.Click += new System.EventHandler(this.showDatebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitbutton.Location = new System.Drawing.Point(579, 532);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(167, 65);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "離開";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearbutton.Location = new System.Drawing.Point(327, 532);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(167, 65);
            this.clearbutton.TabIndex = 11;
            this.clearbutton.Text = "清除";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.showDatebutton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.dayOfMonthTextbox);
            this.Controls.Add(this.MonthTextbox);
            this.Controls.Add(this.dayOfWeekTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayOfWeekTextbox;
        private System.Windows.Forms.TextBox MonthTextbox;
        private System.Windows.Forms.TextBox dayOfMonthTextbox;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDatebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

