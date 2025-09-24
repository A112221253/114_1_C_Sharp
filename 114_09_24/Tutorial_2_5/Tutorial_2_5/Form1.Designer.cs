namespace Tutorial_2_5
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
            this.showbackbutton = new System.Windows.Forms.Button();
            this.showfacebutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showbackbutton
            // 
            this.showbackbutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbackbutton.Location = new System.Drawing.Point(130, 363);
            this.showbackbutton.Name = "showbackbutton";
            this.showbackbutton.Size = new System.Drawing.Size(177, 46);
            this.showbackbutton.TabIndex = 2;
            this.showbackbutton.Text = "顯示背面";
            this.showbackbutton.UseVisualStyleBackColor = true;
            this.showbackbutton.Click += new System.EventHandler(this.showbackbutton_Click);
            // 
            // showfacebutton
            // 
            this.showfacebutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showfacebutton.Location = new System.Drawing.Point(437, 363);
            this.showfacebutton.Name = "showfacebutton";
            this.showfacebutton.Size = new System.Drawing.Size(177, 46);
            this.showfacebutton.TabIndex = 3;
            this.showfacebutton.Text = "正顯示面";
            this.showfacebutton.UseVisualStyleBackColor = true;
            this.showfacebutton.Click += new System.EventHandler(this.showfacebutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tutorial_2_5.Properties.Resources.Ace_Hearts;
            this.pictureBox2.Location = new System.Drawing.Point(437, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 303);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tutorial_2_5.Properties.Resources.Backface_Red;
            this.pictureBox1.Location = new System.Drawing.Point(119, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 463);
            this.Controls.Add(this.showfacebutton);
            this.Controls.Add(this.showbackbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button showbackbutton;
        private System.Windows.Forms.Button showfacebutton;
    }
}

