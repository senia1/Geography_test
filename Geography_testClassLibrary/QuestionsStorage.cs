using Newtonsoft.Json;

namespace Geography_testClassLibrary
{
    public static class QuestionsStorage
    {
        public static string fileName = "questions.json";
        public static void Add(Question newQuestion)
        {
            var listQuestions = GetAll();
            listQuestions.Add(newQuestion);
            Serialize(listQuestions);
        }
        public static void Serialize(List<Question> listQuestions)
        {
            var jsonData = JsonConvert.SerializeObject(listQuestions, Formatting.Indented);

            FileProvider.Replace(fileName, jsonData);
        }
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(fileName))
            {
                var fileData = FileProvider.Get(fileName);

                questions = JsonConvert.DeserializeObject<List<Question>>(fileData);

                return questions;
            }
            else
            {
                questions.Add(new Question("How many oceans are there on Earth?", 5));
                questions.Add(new Question("How many continents are on Earth?", 6));
                questions.Add(new Question("How many billion people make up the world's population?", 8));
                questions.Add(new Question("The height of the tallest mountain on Earth? (in km not rounded)", 8848));
                questions.Add(new Question("How many kilometers is the depth of the Mariana Trench? (rounded)", 11));

                Serialize(questions);
            }
            return questions;
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == removeQuestion.Text)
                {
                    questions.Remove(questions[i]);
                    break;
                }
            }
            FileProvider.Clear(fileName);
            Serialize(questions);
        }
    }
}