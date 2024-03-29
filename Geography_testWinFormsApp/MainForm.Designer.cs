﻿namespace Geography_testWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.resultsButton = new System.Windows.Forms.Button();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.startTestButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Pink;
            this.nextButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.ForeColor = System.Drawing.Color.DimGray;
            this.nextButton.Location = new System.Drawing.Point(339, 345);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(171, 48);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionNumberLabel.ForeColor = System.Drawing.Color.DimGray;
            this.questionNumberLabel.Location = new System.Drawing.Point(133, 107);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(121, 29);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Question #";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionTextLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.questionTextLabel.Location = new System.Drawing.Point(38, 163);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(173, 35);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Question text";
            // 
            // resultsButton
            // 
            this.resultsButton.BackColor = System.Drawing.Color.Silver;
            this.resultsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultsButton.ForeColor = System.Drawing.Color.DimGray;
            this.resultsButton.Location = new System.Drawing.Point(80, 345);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(171, 48);
            this.resultsButton.TabIndex = 3;
            this.resultsButton.Text = "Results";
            this.resultsButton.UseVisualStyleBackColor = false;
            this.resultsButton.Visible = false;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(142, 258);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(150, 31);
            this.userAnswerTextBox.TabIndex = 0;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.timerLabel.Location = new System.Drawing.Point(311, 262);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(25, 29);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "0";
            // 
            // updateButton
            // 
            this.updateButton.BackgroundImage = global::Geography_testWinFormsApp.Properties.Resources.Clear_37294;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Location = new System.Drawing.Point(80, 258);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(39, 34);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "-";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // startTestButton
            // 
            this.startTestButton.BackgroundImage = global::Geography_testWinFormsApp.Properties.Resources.start_48_44541;
            this.startTestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTestButton.Location = new System.Drawing.Point(80, 102);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(39, 35);
            this.startTestButton.TabIndex = 7;
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            this.startTestButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.startTestButton_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultsToolStripMenuItem,
            this.questionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 32);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.resultsToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.restartToolStripMenuItem.Text = "Results";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.exitToolStripMenuItem.Text = "Restart";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(170, 34);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsListToolStripMenuItem,
            this.addAQuestionToolStripMenuItem,
            this.deleteAQuestionToolStripMenuItem});
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.questionsToolStripMenuItem.Text = "Questions";
            // 
            // questionsListToolStripMenuItem
            // 
            this.questionsListToolStripMenuItem.Name = "questionsListToolStripMenuItem";
            this.questionsListToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.questionsListToolStripMenuItem.Text = "List of questions";
            this.questionsListToolStripMenuItem.Click += new System.EventHandler(this.questionsListToolStripMenuItem_Click);
            // 
            // addAQuestionToolStripMenuItem
            // 
            this.addAQuestionToolStripMenuItem.Name = "addAQuestionToolStripMenuItem";
            this.addAQuestionToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.addAQuestionToolStripMenuItem.Text = "Add a question";
            this.addAQuestionToolStripMenuItem.Click += new System.EventHandler(this.addAQuestionToolStripMenuItem_Click);
            // 
            // deleteAQuestionToolStripMenuItem
            // 
            this.deleteAQuestionToolStripMenuItem.Name = "deleteAQuestionToolStripMenuItem";
            this.deleteAQuestionToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.deleteAQuestionToolStripMenuItem.Text = "Delete a question";
            this.deleteAQuestionToolStripMenuItem.Click += new System.EventHandler(this.deleteAQuestionToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Geography_testWinFormsApp.Properties.Resources.globe_geography_world_earth_icon_220473;
            this.pictureBox1.Location = new System.Drawing.Point(692, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.nextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geography_test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private Button resultsButton;
        private TextBox userAnswerTextBox;
        private Label timerLabel;
        private Button updateButton;
        private Button startTestButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resultsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem questionsToolStripMenuItem;
        private ToolStripMenuItem questionsListToolStripMenuItem;
        private ToolStripMenuItem addAQuestionToolStripMenuItem;
        private ToolStripMenuItem deleteAQuestionToolStripMenuItem;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
    }
}