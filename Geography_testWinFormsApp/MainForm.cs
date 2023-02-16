using Geography_testClassLibrary;

namespace Geography_testWinFormsApp
{
    public partial class MainForm : Form
    {
        public List<Question> questions;
        private List<User> users;
        private Question currentQuestion;
        private User user;
        private int countQuestions;
        private int questionNumber;
        private int ticks;
        private bool timerOver;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();

            user = new User(welcomeForm.userNameTextBox.Text, 0, "Unknown");

            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;

            questionNumber = 0;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            ticks = 0;
            timerOver = false;
            timer.Start();

            var random = new Random();

            var randomIndex = random.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];

            questionTextLabel.Text = currentQuestion.Text;
            questionNumber++;

            userAnswerTextBox.Text = "";
            questionNumberLabel.Text = "Question ¹ " + questionNumber;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            userAnswerTextBox.Text = "";
            userAnswerTextBox.Focus();
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            user.RightAnswersCount = 0;
            resultsButton.Visible = false;
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;

            questionNumber = 0;
            ShowNextQuestion();
        }

        private void startTestButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(startTestButton, "Start again");
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            ticks++;
            timerLabel.Text = ticks.ToString();

            if (ticks == 10)
            {
                timerLabel.Text = "";
                timer.Stop();
                timerOver = true;
                MessageBox.Show("The time for answering the question has expired, the answer will be counted as incorrect");

                nextButton.PerformClick();
            }
        }

        private void questionsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allQuestionsForm = new AllQuestionsForm();
            allQuestionsForm.Show();
        }

        private void deleteAQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.Show();
        }

        private void addAQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionsForm = new AddQuestionsForm();
            questionsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed && !timerOver)
            {
                MessageBox.Show(errorMessage);
                userAnswerTextBox.Text = "";
            }
            else
            {
                var rightAnswer = currentQuestion.Answer;
                if (!timerOver)
                {
                    if (userAnswer == rightAnswer)
                    {
                        user.AcceptRightAnswer();
                    }
                }
                questions.Remove(currentQuestion);

                var endGame = questions.Count == 0;
                if (endGame)
                {
                    timer.Stop();
                    timerLabel.Text = "";

                    user.Diagnos = DiagnoseCalculator.Calculate(countQuestions, user);
                    MessageBox.Show($"{user.Name}, Your grade: {user.Diagnos}", "Grade");

                    UserResultsStorage.Safe(user);

                    userAnswerTextBox.Text = "";
                    questionTextLabel.Text = "Text of the question";
                    questionNumberLabel.Text = "Question ¹ ";
                    resultsButton.Visible = true;

                    users = UserResultsStorage.GetAll();
                    return;
                }
                ShowNextQuestion();
            }
            userAnswerTextBox.Focus();
        }
    }
}