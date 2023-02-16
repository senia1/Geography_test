using Geography_testClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_testWinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        //List<Question> questions;
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            //var indexCurrentRow = questionsToDeleteDataGridView.CurrentCell.RowIndex;
            //questionsToDeleteDataGridView.Rows.Remove(questionsToDeleteDataGridView.CurrentRow);

            //QuestionsStorage.Remove(questions[indexCurrentRow]);
            //MessageBox.Show("Your question has been deleted");
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            //questions = QuestionsStorage.GetAll();

            //foreach (var question in questions)
            //{
            //    questionsToDeleteDataGridView.Rows.Add(question.Text);
            //}
        }
    }
}
