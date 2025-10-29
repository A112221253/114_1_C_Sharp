namespace MultipleConditionsDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label gradelabel;
        private System.Windows.Forms.TextBox scoretextbox;
        private System.Windows.Forms.Button judgeButton_Click;

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
            this.gradelabel = new System.Windows.Forms.Label();
            this.scoretextbox = new System.Windows.Forms.TextBox();
            this.judgeButton_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradelabel
            // 
            this.gradelabel.AutoSize = true;
            this.gradelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradelabel.Location = new System.Drawing.Point(26, 18);
            this.gradelabel.Name = "gradelabel";
            this.gradelabel.Size = new System.Drawing.Size(154, 52);
            this.gradelabel.TabIndex = 0;
            this.gradelabel.Text = "成績：";
            // 
            // scoretextbox
            // 
            this.scoretextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretextbox.Location = new System.Drawing.Point(186, 18);
            this.scoretextbox.Name = "scoretextbox";
            this.scoretextbox.Size = new System.Drawing.Size(206, 57);
            this.scoretextbox.TabIndex = 1;
            // 
            // judgeButton_Click
            // 
            this.judgeButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judgeButton_Click.Location = new System.Drawing.Point(53, 332);
            this.judgeButton_Click.Name = "judgeButton_Click";
            this.judgeButton_Click.Size = new System.Drawing.Size(225, 81);
            this.judgeButton_Click.TabIndex = 2;
            this.judgeButton_Click.Text = "等級判斷";
            this.judgeButton_Click.UseVisualStyleBackColor = true;
            this.judgeButton_Click.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "等級：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.judgeButton_Click);
            this.Controls.Add(this.scoretextbox);
            this.Controls.Add(this.gradelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

