using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1------------------>Pyramid Star Pattern
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //2------------------------>Swap Two Numbers Without Third Variable
            int a = 10;
            int b = 20;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //3------------------------->Find Niven Numbers in Array

            int[] arr = { 13, 433, 49, 420, 4991 };

            foreach (int num in arr)
            {
                int sum = 0;
                int temp = num;

                while (temp > 0)
                {
                    sum = sum + temp % 10;
                    temp = temp / 10;
                }

                if (num % sum == 0)
                {
                    Console.WriteLine(num);
                }
            }

            //4----------->Find Min and Max in Array
            int[] arr1 = { 5, 2, 8, 1, 9 };

            int min = arr1[0];
            int max = arr1[0];

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                    min = arr1[i];

                if (arr1[i] > max)
                    max = arr1[i];
            }

            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);

            //5--------------------->Count Duplicate Elements in Array
            int[] ar = { 5, 1, 1 };
            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Duplicate count = " + count);

            //6-------------------->Merge Two Arrays and Sort
            int[] ar1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };

            int[] merged = new int[ar1.Length + arr2.Length];

            ar1.CopyTo(merged, 0);
            arr2.CopyTo(merged, ar1.Length);

            Array.Sort(merged);

            foreach (int num in merged)
            {
                Console.Write(num + " ");
            }

        }

    }

    }




