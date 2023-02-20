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
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allQuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteQuestionCloseButton
            // 
            this.deleteQuestionCloseButton.BackColor = System.Drawing.Color.Pink;
            this.deleteQuestionCloseButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestionCloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.deleteQuestionCloseButton.Location = new System.Drawing.Point(607, 374);
            this.deleteQuestionCloseButton.Name = "deleteQuestionCloseButton";
            this.deleteQuestionCloseButton.Size = new System.Drawing.Size(155, 52);
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
            this.allQuestionsDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.allQuestionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuestionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.questions,
            this.AnswersColumn});
            this.allQuestionsDataGridView.Location = new System.Drawing.Point(76, 46);
            this.allQuestionsDataGridView.Name = "allQuestionsDataGridView";
            this.allQuestionsDataGridView.RowHeadersWidth = 62;
            this.allQuestionsDataGridView.RowTemplate.Height = 33;
            this.allQuestionsDataGridView.Size = new System.Drawing.Size(650, 225);
            this.allQuestionsDataGridView.TabIndex = 3;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "№";
            this.NumberColumn.MinimumWidth = 8;
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.Width = 68;
            // 
            // questions
            // 
            this.questions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questions.HeaderText = "Questions";
            this.questions.MinimumWidth = 8;
            this.questions.Name = "questions";
            this.questions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AnswersColumn
            // 
            this.AnswersColumn.HeaderText = "Answers";
            this.AnswersColumn.MinimumWidth = 8;
            this.AnswersColumn.Name = "AnswersColumn";
            this.AnswersColumn.Width = 114;
            // 
            // AllQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
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
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn questions;
        private DataGridViewTextBoxColumn AnswersColumn;
    }
}