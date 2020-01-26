using System;
using System.Collections.Generic;
using System.Text;

namespace AudreyAllen_Assignment1
{
    class testTests
    {
        public static void Main (string[] args)
        {
            string firstName;
            string lastName;
            int count = 0;
            double classAverage = 0.0;
            int[] testScores = new int [5];
            Tests[] Tests = new Tests[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a student's first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter the student's last name: ");
                lastName = Console.ReadLine();
                for (int j = 0; j < testScores.Length; j++)
                {
                    Console.Write("Enter " + firstName + " " + lastName + "'s score for test " + (j+1) + ": ");
                    testScores[j] = Convert.ToInt32(Console.ReadLine());
                }
                Tests[count] = new Tests(firstName, lastName, testScores);
                count++;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("{0, -13} {1, -13} {2, -8} {3, -8} {4, -8} {5, -8} {6, -8} {7, -12} {8, -7}", "First Name: ", "Last Name: ", "Test 1: ", "Test 2: ","Test 3: ", "Test 4: ", "Test 5: ", "Average: ", "Grade:"));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Tests[i].toString());
                classAverage = classAverage + Tests[i].getAverage();
            }
            classAverage = classAverage / 10;
            Console.WriteLine();
            Console.WriteLine("Class average: " + classAverage);
        }
    }
}
