namespace RPSGame
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
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.stoneButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.computerLabel.Location = new System.Drawing.Point(187, 29);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(110, 32);
            this.computerLabel.TabIndex = 2;
            this.computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerLabel.Location = new System.Drawing.Point(479, 29);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(110, 32);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "玩家出";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(359, 259);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 18);
            this.resultLabel.TabIndex = 4;
            // 
            // stoneButton
            // 
            this.stoneButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stoneButton.Location = new System.Drawing.Point(139, 299);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(144, 61);
            this.stoneButton.TabIndex = 5;
            this.stoneButton.Text = "石頭";
            this.stoneButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paperButton.Location = new System.Drawing.Point(334, 299);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(130, 61);
            this.paperButton.TabIndex = 6;
            this.paperButton.Text = "布";
            this.paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorButton
            // 
            this.scissorButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scissorButton.Location = new System.Drawing.Point(520, 299);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(138, 61);
            this.scissorButton.TabIndex = 7;
            this.scissorButton.Text = "剪刀";
            this.scissorButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(284, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(232, 48);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "結束遊戲";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::WindowsFormsApp2.Properties.Resources.stone_player;
            this.playerPictureBox.Location = new System.Drawing.Point(440, 96);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(202, 112);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPictureBox.TabIndex = 1;
            this.playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Image = global::WindowsFormsApp2.Properties.Resources.stone_computer;
            this.computerPictureBox.Location = new System.Drawing.Point(139, 96);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(207, 112);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPictureBox.TabIndex = 0;
            this.computerPictureBox.TabStop = false;
            this.computerPictureBox.Click += new System.EventHandler(this.computerPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.stoneButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.computerPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;
    }
}

