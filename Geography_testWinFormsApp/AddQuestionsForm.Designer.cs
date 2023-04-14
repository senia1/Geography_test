namespace Geography_testWinFormsApp
{
    partial class AddQuestionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionsForm));
            this.addNewQuestionLabel = new System.Windows.Forms.Label();
            this.addNewAnswerLabel = new System.Windows.Forms.Label();
            this.addNewQuestionTextBox = new System.Windows.Forms.TextBox();
            this.addNewAnswerTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuestionLabel
            // 
            this.addNewQuestionLabel.AutoSize = true;
            this.addNewQuestionLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewQuestionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.addNewQuestionLabel.Location = new System.Drawing.Point(70, 45);
            this.addNewQuestionLabel.Name = "addNewQuestionLabel";
            this.addNewQuestionLabel.Size = new System.Drawing.Size(269, 35);
            this.addNewQuestionLabel.TabIndex = 0;
            this.addNewQuestionLabel.Text = "Enter a new question:";
            // 
            // addNewAnswerLabel
            // 
            this.addNewAnswerLabel.AutoSize = true;
            this.addNewAnswerLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewAnswerLabel.ForeColor = System.Drawing.Color.DimGray;
            this.addNewAnswerLabel.Location = new System.Drawing.Point(70, 230);
            this.addNewAnswerLabel.Name = "addNewAnswerLabel";
            this.addNewAnswerLabel.Size = new System.Drawing.Size(212, 35);
            this.addNewAnswerLabel.TabIndex = 1;
            this.addNewAnswerLabel.Text = "Enter an answer:";
            // 
            // addNewQuestionTextBox
            // 
            this.addNewQuestionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewQuestionTextBox.Location = new System.Drawing.Point(70, 122);
            this.addNewQuestionTextBox.Name = "addNewQuestionTextBox";
            this.addNewQuestionTextBox.Size = new System.Drawing.Size(632, 31);
            this.addNewQuestionTextBox.TabIndex = 2;
            this.addNewQuestionTextBox.TextChanged += new System.EventHandler(this.addNewQuestionTextBox_TextChanged);
            // 
            // addNewAnswerTextBox
            // 
            this.addNewAnswerTextBox.Location = new System.Drawing.Point(70, 314);
            this.addNewAnswerTextBox.Name = "addNewAnswerTextBox";
            this.addNewAnswerTextBox.Size = new System.Drawing.Size(632, 31);
            this.addNewAnswerTextBox.TabIndex = 3;
            this.addNewAnswerTextBox.TextChanged += new System.EventHandler(this.addNewAnswerTextBox_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.LightPink;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(538, 385);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(186, 50);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewQuestionButton.BackColor = System.Drawing.Color.LightPink;
            this.addNewQuestionButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewQuestionButton.ForeColor = System.Drawing.Color.DimGray;
            this.addNewQuestionButton.Location = new System.Drawing.Point(70, 385);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(186, 50);
            this.addNewQuestionButton.TabIndex = 5;
            this.addNewQuestionButton.Text = "Add";
            this.addNewQuestionButton.UseVisualStyleBackColor = false;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addNewQuestionButton_Click);
            // 
            // AddQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addNewAnswerTextBox);
            this.Controls.Add(this.addNewQuestionTextBox);
            this.Controls.Add(this.addNewAnswerLabel);
            this.Controls.Add(this.addNewQuestionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addNewQuestionLabel;
        private Label addNewAnswerLabel;
        private TextBox addNewQuestionTextBox;
        private TextBox addNewAnswerTextBox;
        private Button closeButton;
        private Button addNewQuestionButton;
    }
}