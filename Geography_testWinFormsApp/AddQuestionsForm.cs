using Geography_testClassLibrary;

namespace Geography_testWinFormsApp
{
    public partial class AddQuestionsForm : Form
    {
        public AddQuestionsForm()
        {
            InitializeComponent();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(addNewAnswerTextBox.Text, out int userAnswer, out string errorMessage);

            if (String.IsNullOrEmpty(addNewQuestionTextBox.Text))
            {
                MessageBox.Show("Question can not be empty");
            }
            else
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
                addNewAnswerTextBox.Text = "";
            }
            else
            {
                var newQuestion = new Question(addNewQuestionTextBox.Text, Convert.ToInt32(addNewAnswerTextBox.Text));
                QuestionsStorage.Add(newQuestion);
                MessageBox.Show("Your question has been added");
                Close();
                var allQuestions = new AllQuestionsForm();
                allQuestions.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewQuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            var allQuestion = QuestionsStorage.GetAll();
            foreach (var question in allQuestion)
            {
                if (addNewQuestionTextBox.Text == question.Text)
                {
                    MessageBox.Show("There is already such a question.");
                    addNewQuestionTextBox.Text = "";
                }
            }
        }

        private void addNewAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addNewQuestionTextBox.Text))
            {
                MessageBox.Show("Enter your question in the previous field.");
            }
        }
    }
}
