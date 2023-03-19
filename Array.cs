using System;
using System.Numerics;

namespace PracticeInCSharp
{
    internal class Array
    {
        static void Main(string[] args)
        {
            var number = new[] { 4,8,5,56,8};
            //length
            Console.WriteLine("Length: "+number.Length);
            //index of
            var index = Array.IndexOf(number,8);
            Console.WriteLine("indexes: "+index);
            //Clear()
            Array.Clear(number,0, 2);
            Console.WriteLine("Effect of clear");
            foreach(var element in number)
                Console.WriteLine(element);
            //Copy
            int[] n = new int[3];
            Array.Copy(number,n,3);
            Console.WriteLine("effects of copy");
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }

            //Sort 
            Array.Sort(number);
            Console.WriteLine("sorting in action:");
            foreach(var elements in number)
                Console.WriteLine(elements);
            //Reverse
            Array.Reverse(number);
            Console.WriteLine("reverse in action:");
            foreach(var i in number)
                Console.WriteLine(i);


        }
    }
}

