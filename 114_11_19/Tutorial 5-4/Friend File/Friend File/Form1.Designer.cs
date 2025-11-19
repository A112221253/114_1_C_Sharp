namespace Friend_File
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// 此處保留原英文說明，但在各控制項初始化區塊加入繁體中文詳細註解。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放所有使用中的資源。
        /// 當 disposing 為 true 時，會同時釋放 managed 資源（components）。
        /// </summary>
        /// <param name="disposing">若為 true，表示要釋放託管資源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計工具所需的方法 - 請勿使用程式碼編輯器修改此方法內容。
        /// 此處會建立與設定所有視窗表單元件（Label, TextBox, Button）。
        /// 已將所有元件文字確認為繁體中文，並將字型大小設為 18。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 19);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(279, 40);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "輸入朋友的名字:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(328, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 48);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // writeNameButton
            // 
            this.writeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeNameButton.Location = new System.Drawing.Point(64, 129);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(227, 61);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "寫名字";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(367, 129);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(211, 61);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 230);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "朋友檔案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

