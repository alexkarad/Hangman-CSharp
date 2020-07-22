namespace Hangman_Project
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.giveUpBtn = new System.Windows.Forms.Button();
            this.checkLetterBtn = new System.Windows.Forms.Button();
            this.letterGuessBox = new System.Windows.Forms.TextBox();
            this.numAttemptsLabel = new System.Windows.Forms.Label();
            this.gameWordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usedLetterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(139, 342);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(113, 66);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "Start New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // giveUpBtn
            // 
            this.giveUpBtn.Location = new System.Drawing.Point(447, 342);
            this.giveUpBtn.Name = "giveUpBtn";
            this.giveUpBtn.Size = new System.Drawing.Size(112, 66);
            this.giveUpBtn.TabIndex = 1;
            this.giveUpBtn.Text = "Give Up";
            this.giveUpBtn.UseVisualStyleBackColor = true;
            this.giveUpBtn.Click += new System.EventHandler(this.giveUpBtn_Click);
            // 
            // checkLetterBtn
            // 
            this.checkLetterBtn.Location = new System.Drawing.Point(44, 103);
            this.checkLetterBtn.Name = "checkLetterBtn";
            this.checkLetterBtn.Size = new System.Drawing.Size(97, 137);
            this.checkLetterBtn.TabIndex = 2;
            this.checkLetterBtn.Text = "Check for a Letter";
            this.checkLetterBtn.UseVisualStyleBackColor = true;
            this.checkLetterBtn.Click += new System.EventHandler(this.checkLetterBtn_Click);
            // 
            // letterGuessBox
            // 
            this.letterGuessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.letterGuessBox.Location = new System.Drawing.Point(158, 103);
            this.letterGuessBox.Name = "letterGuessBox";
            this.letterGuessBox.Size = new System.Drawing.Size(81, 57);
            this.letterGuessBox.TabIndex = 3;
            this.letterGuessBox.TextChanged += new System.EventHandler(this.letterGuessBox_TextChanged);
            // 
            // numAttemptsLabel
            // 
            this.numAttemptsLabel.AutoSize = true;
            this.numAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.numAttemptsLabel.Location = new System.Drawing.Point(155, 176);
            this.numAttemptsLabel.Name = "numAttemptsLabel";
            this.numAttemptsLabel.Size = new System.Drawing.Size(109, 39);
            this.numAttemptsLabel.TabIndex = 4;
            this.numAttemptsLabel.Text = "label1";
            this.numAttemptsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameWordLabel
            // 
            this.gameWordLabel.AutoSize = true;
            this.gameWordLabel.BackColor = System.Drawing.Color.White;
            this.gameWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.gameWordLabel.Location = new System.Drawing.Point(275, 32);
            this.gameWordLabel.Name = "gameWordLabel";
            this.gameWordLabel.Size = new System.Drawing.Size(0, 58);
            this.gameWordLabel.TabIndex = 5;
            this.gameWordLabel.Click += new System.EventHandler(this.gameWordLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(139, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Used Letters:";
            // 
            // usedLetterLabel
            // 
            this.usedLetterLabel.AutoSize = true;
            this.usedLetterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usedLetterLabel.Location = new System.Drawing.Point(139, 291);
            this.usedLetterLabel.Name = "usedLetterLabel";
            this.usedLetterLabel.Size = new System.Drawing.Size(64, 25);
            this.usedLetterLabel.TabIndex = 7;
            this.usedLetterLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 523);
            this.Controls.Add(this.usedLetterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameWordLabel);
            this.Controls.Add(this.numAttemptsLabel);
            this.Controls.Add(this.letterGuessBox);
            this.Controls.Add(this.checkLetterBtn);
            this.Controls.Add(this.giveUpBtn);
            this.Controls.Add(this.newGameBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button giveUpBtn;
        private System.Windows.Forms.Button checkLetterBtn;
        private System.Windows.Forms.TextBox letterGuessBox;
        private System.Windows.Forms.Label numAttemptsLabel;
        private System.Windows.Forms.Label gameWordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usedLetterLabel;
    }
}

