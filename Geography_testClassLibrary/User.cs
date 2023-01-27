using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_testClassLibrary
{
    public class User
    {
        public string Name;
        public string Diagnos;
        public int RightAnswersCount = 0;

        public User(string name, int rightAnswersCount, string diagnos)
        {
            Name = name;
            RightAnswersCount = rightAnswersCount;
            Diagnos = diagnos;
        }

        public void AcceptRightAnswer()
        {
            RightAnswersCount++;
        }
    }
}