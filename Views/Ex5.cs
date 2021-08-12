using System;
using FirstActivity.utils;

namespace FirstActivity.Views
{
    public class Ex5
    {
        public static void runExercise()
        {
            Console.WriteLine("\nExercise 5:");
            Console.Write("\nEnter a positive int number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 0)
            {
                Console.Write("\nEnter a POSITIVE int number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            numbers.getFibonacciSequence(number);
        }
    }
}