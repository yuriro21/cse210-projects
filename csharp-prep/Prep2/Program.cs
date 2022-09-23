using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2 Grade Calculator");
            Console.Write("What is your grade percentage? ");
            string gradePercentage = Console.ReadLine();
            int grade = int.Parse(gradePercentage);
            string letter = "";
            string sing = "";

            int remainder = grade % 10;

            if (remainder >= 7)
            {
                sing = "+";
            }
            else if (remainder < 3)
            {
                sing = "-";
            }
            else
            {
                sing = "";
            }

            if (grade >= 70)
            {
                Console.WriteLine("Congratulation! You pass the curse.");
            }
            else
            {
                Console.WriteLine("Sorry, you not pass the curse. You can try again.");
            }

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }

            else
            {
                letter = "F";
            }

            if (grade >= 93)
            {
                sing = "";
            }

            if (letter == "F")
            {
                sing = "";
            }


            Console.WriteLine($"Your grade is {letter}{sing}");

        }
    }
}
