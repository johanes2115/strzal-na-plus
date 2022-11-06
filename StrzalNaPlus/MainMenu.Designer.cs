namespace StrzalNaPlus
{
    partial class MainMenu
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
            this.StartButton = new System.Windows.Forms.Button();
            this.DifficultyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Gainsboro;
            this.StartButton.Location = new System.Drawing.Point(459, 360);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 25);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DifficultyButton
            // 
            this.DifficultyButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DifficultyButton.Location = new System.Drawing.Point(459, 391);
            this.DifficultyButton.Name = "DifficultyButton";
            this.DifficultyButton.Size = new System.Drawing.Size(100, 25);
            this.DifficultyButton.TabIndex = 1;
            this.DifficultyButton.Text = "Difficulty";
            this.DifficultyButton.UseVisualStyleBackColor = false;
            this.DifficultyButton.Click += new System.EventHandler(this.DifficultyButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.Location = new System.Drawing.Point(459, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 25);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(486, 150);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(35, 13);
            this.DifficultyLabel.TabIndex = 2;
            this.DifficultyLabel.Text = "label1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1008, 747);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DifficultyButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button DifficultyButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DifficultyLabel;
    }
}