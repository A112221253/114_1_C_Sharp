namespace Sale_Price_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.originalPriceTextBox.Location = new System.Drawing.Point(508, 32);
            this.originalPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(293, 60);
            this.originalPriceTextBox.TabIndex = 0;
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountPercentageTextBox.Location = new System.Drawing.Point(508, 113);
            this.discountPercentageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(293, 60);
            this.discountPercentageTextBox.TabIndex = 1;
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.originalPricePromptLabel.Location = new System.Drawing.Point(100, 32);
            this.originalPricePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(371, 44);
            this.originalPricePromptLabel.TabIndex = 2;
            this.originalPricePromptLabel.Text = "請輸入商品原價：";
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(56, 116);
            this.discPercentagePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(415, 44);
            this.discPercentagePromptLabel.TabIndex = 3;
            this.discPercentagePromptLabel.Text = "請輸入折扣百分比：";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(217, 281);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(239, 44);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "特價金額：";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.salePriceLabel.Location = new System.Drawing.Point(508, 281);
            this.salePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(293, 44);
            this.salePriceLabel.TabIndex = 5;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(102, 383);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(268, 54);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算特價";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(534, 383);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(188, 54);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 487);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.originalPriceTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "特價計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.Label originalPricePromptLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

