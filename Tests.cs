using System;

namespace AudreyAllen_Assignment1
{
    class Tests
    {
        private string firstName;
        private string lastName;
        private double[] testScores;
        public Tests(string newFirst, string newLast, int [] newScores)
        {
            firstName = newFirst;
            lastName = newLast;
            testScores = new double [5];
            for (int i = 0; i < testScores.Length; i++)
            {
                testScores[i] = newScores[i];
            }
        }
        public void setFirst (string newFirst)
        {
            firstName = newFirst;
        }
        public string getFirst ()
        {
            return firstName;
        }
        public void setLast (string newLast)
        {
            lastName = newLast;
        }
        public string getLast ()
        {
            return lastName;
        }
        public void setScores (double [] newScores)
        {
            testScores = newScores;
        }
        public double [] getScores ()
        {
            return testScores;
        }
        public double getAverage ()
        {
            double average = 0.0;
            for (int i = 0; i < testScores.Length; i++)
            {
                average = average + testScores[i];
            }
            average = average / testScores.Length;
            return average;
        }
        public char getLetter ()
        {
            double condition = (int)getAverage() / 10;
            char letterGrade;
            switch (condition)
            {
                case 10:
                    letterGrade = 'A';
                    return letterGrade;
                case 9:
                    letterGrade = 'A';
                    return letterGrade;
                case 8:
                    letterGrade = 'B';
                    return letterGrade;
                case 7:
                    letterGrade = 'C';
                    return letterGrade;
                case 6:
                    letterGrade = 'D';
                    return letterGrade;
                default:
                    letterGrade = 'F';
                    return letterGrade;
            }
        }
        public string toString ()
        {
            return string.Format("{0, -13} {1, -13} {2, -8} {3, -8} {4, -8} {5, -8} {6, -8} {7, -12} {8, -7}", firstName, lastName, testScores[0], testScores[1], testScores[2], testScores[3], testScores[4], getAverage().ToString("0.00"), getLetter());
        }
    }
}

