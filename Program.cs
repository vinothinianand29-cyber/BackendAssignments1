using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-------------- > Reverse a Number

            int num, reverse = 0, remainder;
            Console.Write("Enter the number : ");

            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }

            Console.WriteLine("Reverse the number is:" + reverse);

            //2------------>Find Largest Among Three Numbers

            int a, b, c;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }

            //3----------->Print Multiplication Table

            int number;

            Console.Write("Enter the number :");

            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (number * i));
            }

           // 4-------------- > Function for Sum of Two Numbers

            int result;

            result = Sum(10, 20);

            Console.WriteLine("Sum is: " + result);

            //5-------------------->Function to Count Spaces in String

            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            CountSpaces(input);

        }

        //4
        static int Sum(int a, int b)
        {
            return a + b;
        }

        //5
        static void CountSpaces(string text)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("Number of spaces: " + count);
        }
    }
}
