using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");

            var stringToReverse = Console.ReadLine();

            var reversedString = "";

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + stringToReverse[i];
            }

            Console.WriteLine($"Reversed String is {reversedString}");
            Console.ReadLine();
        }
    }
}
