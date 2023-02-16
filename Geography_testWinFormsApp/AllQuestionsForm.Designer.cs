namespace Geography_testWinFormsApp
{
    partial class AllQuestionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllQuestionsForm));
            this.deleteQuestionCloseButton = new System.Windows.Forms.Button();
            this.allQuestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.questionNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allQuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteQuestionCloseButton
            // 
            this.deleteQuestionCloseButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.deleteQuestionCloseButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestionCloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.deleteQuestionCloseButton.Location = new System.Drawing.Point(630, 380);
            this.deleteQuestionCloseButton.Name = "deleteQuestionCloseButton";
            this.deleteQuestionCloseButton.Size = new System.Drawing.Size(132, 46);
            this.deleteQuestionCloseButton.TabIndex = 0;
            this.deleteQuestionCloseButton.Text = "Close";
            this.deleteQuestionCloseButton.UseVisualStyleBackColor = false;
            this.deleteQuestionCloseButton.Click += new System.EventHandler(this.deleteQuestionCloseButton_Click);
            // 
            // allQuestionsDataGridView
            // 
            this.allQuestionsDataGridView.AllowUserToAddRows = false;
            this.allQuestionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allQuestionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allQuestionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allQuestionsDataGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.allQuestionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuestionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionNumberColumn,
            this.questionsColumn,
            this.answersColumn});
            this.allQuestionsDataGridView.Location = new System.Drawing.Point(62, 40);
            this.allQuestionsDataGridView.Name = "allQuestionsDataGridView";
            this.allQuestionsDataGridView.RowHeadersWidth = 62;
            this.allQuestionsDataGridView.RowTemplate.Height = 33;
            this.allQuestionsDataGridView.Size = new System.Drawing.Size(673, 225);
            this.allQuestionsDataGridView.TabIndex = 1;
            // 
            // questionNumberColumn
            // 
            this.questionNumberColumn.HeaderText = "#";
            this.questionNumberColumn.MinimumWidth = 8;
            this.questionNumberColumn.Name = "questionNumberColumn";
            this.questionNumberColumn.Width = 59;
            // 
            // questionsColumn
            // 
            this.questionsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questionsColumn.HeaderText = "Questions";
            this.questionsColumn.MinimumWidth = 8;
            this.questionsColumn.Name = "questionsColumn";
            // 
            // answersColumn
            // 
            this.answersColumn.HeaderText = "Answers";
            this.answersColumn.MinimumWidth = 8;
            this.answersColumn.Name = "answersColumn";
            this.answersColumn.Width = 114;
            // 
            // AllQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allQuestionsDataGridView);
            this.Controls.Add(this.deleteQuestionCloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of all questions";
            this.Load += new System.EventHandler(this.AllQuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allQuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button deleteQuestionCloseButton;
        private DataGridView allQuestionsDataGridView;
        private DataGridViewTextBoxColumn questionNumberColumn;
        private DataGridViewTextBoxColumn questionsColumn;
        private DataGridViewTextBoxColumn answersColumn;
    }
}