namespace ProcessingAnArray
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
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highestScoreLabel = new System.Windows.Forms.Label();
            this.lowestScoreLabel = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Location = new System.Drawing.Point(24, 35);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(155, 121);
            this.testScoresListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Scores ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Highest ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lowest ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average";
            // 
            // highestScoreLabel
            // 
            this.highestScoreLabel.Location = new System.Drawing.Point(276, 61);
            this.highestScoreLabel.Name = "highestScoreLabel";
            this.highestScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.highestScoreLabel.TabIndex = 5;
            this.highestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowestScoreLabel
            // 
            this.lowestScoreLabel.Location = new System.Drawing.Point(276, 94);
            this.lowestScoreLabel.Name = "lowestScoreLabel";
            this.lowestScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.lowestScoreLabel.TabIndex = 6;
            this.lowestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.Location = new System.Drawing.Point(276, 126);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.averageScoreLabel.TabIndex = 7;
            this.averageScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(79, 187);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 38);
            this.scoreButton.TabIndex = 8;
            this.scoreButton.Text = "Get Score ";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(204, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.lowestScoreLabel);
            this.Controls.Add(this.highestScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testScoresListBox);
            this.Name = "Form1";
            this.Text = "Test Average ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highestScoreLabel;
        private System.Windows.Forms.Label lowestScoreLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button exitButton;
    }
}

