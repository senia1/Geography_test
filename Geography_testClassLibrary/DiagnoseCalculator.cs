
namespace Geography_testClassLibrary
{
    public static class DiagnoseCalculator
    {
        public static string Calculate(int countQuestions, User user)
        {
            var diagnoses = new[]
        {
                 "Beginning",
                 "Elementary",
                 "Almost average",
                 "Normal!",
                 "Talent!",
                 "Genius!"
        };
            double average = (user.RightAnswersCount / (Convert.ToDouble(countQuestions))) * 100;

            if (average < 20) { return diagnoses[0]; }
            if (average < 40) { return diagnoses[1]; }
            if (average < 60) { return diagnoses[2]; }
            if (average < 80) { return diagnoses[3]; }
            if (average < 100) { return diagnoses[4]; }

            return diagnoses[5];
        }
    }
}