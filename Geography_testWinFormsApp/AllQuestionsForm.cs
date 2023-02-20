using Geography_testClassLibrary;

namespace Geography_testWinFormsApp
{
    public partial class AllQuestionsForm : Form
    {
        List<Question> allQuestions;
        int allQuestionsNumber;
        public AllQuestionsForm()
        {
            InitializeComponent();
        }

        private void AllQuestionsForm_Load(object sender, EventArgs e)
        {
            allQuestions = QuestionsStorage.GetAll();

            foreach (var question in allQuestions)
            {
                allQuestionsNumber++;
                allQuestionsDataGridView.Rows.Add(allQuestionsNumber,question.Text, question.Answer);
            }
        }

        private void deleteQuestionCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
