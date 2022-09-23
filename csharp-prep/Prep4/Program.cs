using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4, List of Numbers");

            List<int> numbersL = new List<int>();

            int numberUser = -1;

            Console.Write("Enter a list of numbers, type 0 when finished.");

            while (numberUser != 0)
            {
                Console.Write("Enter a number ");
                numberUser = int.Parse(Console.ReadLine());
                numbersL.Add(numberUser);
            }
      
            int sum = 0;
            int count = -1;            
            int largest = 0;            

            foreach (int N in numbersL)
            {
                sum += N;
                count = count + 1;
                
                if (largest < N)
                {
                    largest = N;
                }                
            }
            
            float average = sum / count;

            Console.WriteLine($"The list have {numbersL.Count} items");
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The larguest number is: {largest}");            
        }
    }
}
