using Geography_testClassLibrary;
using System.Timers;

class Program
{
    static System.Timers.Timer questionTimer = new System.Timers.Timer(1000);
    static System.Timers.Timer tenSecondTimer = new System.Timers.Timer(10000);
    static int seconds = 0;
    static bool timerIsOver = false;
    static void Main(string[] args)
    {
        User user = new User(GetUserName(), 0, "unknown");

        questionTimer.Elapsed += QuestionTimer_Elapsed;
        tenSecondTimer.Elapsed += QuestionTimer_Elapsed_2;

        do
        {
            var questions = QuestionsStorage.GetAll();
            var questionsCount = questions.Count;

            var countRightAnswers = PlayGame(questions);
            //var diagnos = GetDiagnos(countRightAnswers, questionsCount);
            user.RightAnswersCount = countRightAnswers;
            
            var diagnos = DiagnoseCalculator.Calculate(questionsCount, user);

            user.Diagnos = diagnos;

            Console.WriteLine($"Number of correct answers: {countRightAnswers}. {user.Name}, Your diagnosis: {diagnos}");

            UserResultsStorage.Safe(user);

        } while (GetUserWish());
    }

    private static void QuestionTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        seconds++;
        string secondCount = seconds.ToString();

        Console.SetCursorPosition((Console.WindowWidth - secondCount.Length) / 2, Console.CursorTop);
        Console.Write($"{secondCount}\r");
    }

    private static void QuestionTimer_Elapsed_2(object sender2, ElapsedEventArgs e2)
    {
        questionTimer.Stop();
        tenSecondTimer.Stop();

        timerIsOver = true;

        Console.WriteLine($"Time is over");
    }

    static string GetUserName()
    {
        Console.WriteLine("Hello! What's your name?");
        var userName = Console.ReadLine();

        while (userName.Length < 1 || userName.Length > 30 || userName.Contains(" "))
        {
            Console.WriteLine("The number of characters in the name must be between 1 and 30 and must not contain spaces, please try again");
            userName = Console.ReadLine();
        }

        return userName;
    }
    
    static bool GetUserWish()
    {
        var yesOrNo = " (Please, enter Yes or No)";

        Console.WriteLine("\nWould you like to see all test results?" + yesOrNo);
        var userWish = GetUserYesOrNo();

        if (userWish)
        {
            ShowTableOfUserResults();
        }
        else
        {
            Console.WriteLine($"We have taken into account your wishes, and no test results\n");
        }

        Console.WriteLine("\nWould you like to add your question?" + yesOrNo);
        userWish = GetUserYesOrNo();

        if (userWish)
        {
            AddNewQuestion();
        }
        else
        {
            Console.WriteLine($"We have taken into account your wishes, and the question will not be added.\n");
        }

        Console.WriteLine("\nWould you like to delete an existing question?" + yesOrNo);
        userWish = GetUserYesOrNo();

        if (userWish)
        {
            RemoveNewQuestion();
        }
        else
        {
            Console.WriteLine($"We have taken into account your wishes. and the question will not be deleted!\n");
        }

        Console.WriteLine("\nWould you like to take the test again??" + yesOrNo);
        return GetUserYesOrNo();
    }

    static void AddNewQuestion()
    {
        Console.WriteLine("Enter question text:");
        var text = Console.ReadLine();
        Console.WriteLine("Enter the answer to the question");
        var answer = GetNumber();

        var newQuestion = new Question(text, answer);
        QuestionsStorage.Add(newQuestion);
    }

    static void RemoveNewQuestion()
    {
        Console.WriteLine("Please enter the number of the question to be deleted:");
        var questions = QuestionsStorage.GetAll();
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + questions[i].Text);
        }
        var removeQuestionsNumber = GetNumber();
        while (removeQuestionsNumber < 1 || removeQuestionsNumber > questions.Count)
        {
            Console.WriteLine($"Please enter a number between 1 and {questions.Count}");
            removeQuestionsNumber = GetNumber();
        }
        var removeQuestion = questions[removeQuestionsNumber - 1];
        QuestionsStorage.Remove(removeQuestion);
    }

    static bool GetUserYesOrNo()
    {
        var userWish = Console.ReadLine().ToLower();

        while (userWish != "no" && userWish != "yes")
        {
            Console.WriteLine("Please enter Yes or No");
            userWish = Console.ReadLine().ToLower();
        }
        return userWish == "yes";
    }

    static int PlayGame(List<Question> questions)
    {
        Console.Clear();

        int numberQuestions = 1;
        int countRightAnswers = 0;
        Random rand = new Random();

        while (questions.Count > 0)
        {
            timerIsOver = false;
            seconds = 0;

            Console.WriteLine($"Question № {numberQuestions}:");

            int randomQuestionIndex = rand.Next(questions.Count);

            Console.WriteLine(questions[randomQuestionIndex].Text);

            tenSecondTimer.Start();
            questionTimer.Start();

            int userAnswer = GetNumber();
            int rightAnswer = questions[randomQuestionIndex].Answer;

            tenSecondTimer.Stop();
            questionTimer.Stop();

            if (userAnswer == rightAnswer && !timerIsOver)
            {
                countRightAnswers++;
            }

            numberQuestions++;
            questions.RemoveAt(randomQuestionIndex);
        }

        return countRightAnswers;
    }

    static int GetNumber()
    {
        int number = 0;

        while (!InputValidator.TryParseToNumber(Console.ReadLine(), out number, out string errorMessage))
        {
            Console.WriteLine(errorMessage);
        }

        return number;
    }

    static void ShowTableOfUserResults()
    {
        var users = UserResultsStorage.GetAll();

        var tablePattern = "| {0,-40} | {1,-40}| {2,-20} |";

        Console.WriteLine(tablePattern, "Name", "Number of correct answers", "Diagnosis");

        foreach (var user in users)
        {
            Console.WriteLine(tablePattern, user.Name, user.RightAnswersCount, user.Diagnos);
        }
    }
}

