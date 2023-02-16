namespace Geography_testWinFormsApp
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.getUserNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.timeWarningLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Pink;
            this.welcomeLabel.Location = new System.Drawing.Point(215, 60);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(340, 88);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // getUserNameLabel
            // 
            this.getUserNameLabel.AutoSize = true;
            this.getUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.getUserNameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getUserNameLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.getUserNameLabel.Location = new System.Drawing.Point(180, 235);
            this.getUserNameLabel.Name = "getUserNameLabel";
            this.getUserNameLabel.Size = new System.Drawing.Size(426, 59);
            this.getUserNameLabel.TabIndex = 1;
            this.getUserNameLabel.Text = "What is your name?";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(237, 319);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(301, 31);
            this.userNameTextBox.TabIndex = 2;
            // 
            // timeWarningLabel
            // 
            this.timeWarningLabel.AutoSize = true;
            this.timeWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeWarningLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timeWarningLabel.Location = new System.Drawing.Point(189, 364);
            this.timeWarningLabel.Name = "timeWarningLabel";
            this.timeWarningLabel.Size = new System.Drawing.Size(388, 25);
            this.timeWarningLabel.TabIndex = 3;
            this.timeWarningLabel.Text = "Attention: you only have 10 seconds to answer!";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.MistyRose;
            this.startButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.DimGray;
            this.startButton.Location = new System.Drawing.Point(296, 413);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(182, 46);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Geography_testWinFormsApp.Properties.Resources.compass_gd665b9ee7_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeWarningLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.getUserNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Geography test!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Label getUserNameLabel;
        public TextBox userNameTextBox;
        private Label timeWarningLabel;
        private Button startButton;
    }
}