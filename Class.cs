using System;
using System.Numerics;

namespace PracticeInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in this format: 3,4,5,6,7:");
            var input = Console.ReadLine();

            string[] output = input.Split(',');
            int max = int.MinValue;
            try
            {
                for (int i = 0; i <= output.Length; i++)
                {
                    int n = int.Parse(output[i]);
                    if (n > max)
                    {
                        max = n;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Array index went out of bound");
            }
            Console.WriteLine("max no. is {0}",max);

            
        }
    }
}

