using System;
using FirstActivity.utils;

namespace FirstActivity.Views
{
    public class Ex2
    {
        public static void runExercise()
        {
            Console.WriteLine("\nExercise 2:");
            Console.Write("\nEnter the value in R$: ");
            double real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"US$ { money.convertToString(real / 5.17) } - EUR { money.convertToString(real / 6.14) } - $ { money.convertToString(real / 0.05) }");
        }
    }
}