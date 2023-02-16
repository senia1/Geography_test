namespace Geography_testWinFormsApp
{
    partial class DeleteQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteQuestionForm));
            this.deleteQuestionCloseButton = new System.Windows.Forms.Button();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.questionsToDeleteDataGridView = new System.Windows.Forms.DataGridView();
            this.questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsToDeleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteQuestionCloseButton
            // 
            this.deleteQuestionCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteQuestionCloseButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.deleteQuestionCloseButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestionCloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.deleteQuestionCloseButton.Location = new System.Drawing.Point(479, 370);
            this.deleteQuestionCloseButton.Name = "deleteQuestionCloseButton";
            this.deleteQuestionCloseButton.Size = new System.Drawing.Size(238, 49);
            this.deleteQuestionCloseButton.TabIndex = 0;
            this.deleteQuestionCloseButton.Text = "Close";
            this.deleteQuestionCloseButton.UseVisualStyleBackColor = false;
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteQuestionButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.deleteQuestionButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestionButton.ForeColor = System.Drawing.Color.DimGray;
            this.deleteQuestionButton.Location = new System.Drawing.Point(88, 370);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(238, 49);
            this.deleteQuestionButton.TabIndex = 1;
            this.deleteQuestionButton.Text = "Delete question";
            this.deleteQuestionButton.UseVisualStyleBackColor = false;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // questionsToDeleteDataGridView
            // 
            this.questionsToDeleteDataGridView.AllowUserToAddRows = false;
            this.questionsToDeleteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsToDeleteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questionsToDeleteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.questionsToDeleteDataGridView.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.questionsToDeleteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionsToDeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsToDeleteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questions});
            this.questionsToDeleteDataGridView.Location = new System.Drawing.Point(75, 47);
            this.questionsToDeleteDataGridView.Name = "questionsToDeleteDataGridView";
            this.questionsToDeleteDataGridView.RowHeadersWidth = 62;
            this.questionsToDeleteDataGridView.RowTemplate.Height = 33;
            this.questionsToDeleteDataGridView.Size = new System.Drawing.Size(650, 225);
            this.questionsToDeleteDataGridView.TabIndex = 2;
            // 
            // questions
            // 
            this.questions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questions.HeaderText = "Questions";
            this.questions.MinimumWidth = 8;
            this.questions.Name = "questions";
            this.questions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionsToDeleteDataGridView);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.deleteQuestionCloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete question";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsToDeleteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button deleteQuestionCloseButton;
        private Button deleteQuestionButton;
        private DataGridView questionsToDeleteDataGridView;
        private DataGridViewTextBoxColumn questions;
    }
}