using System;
using FirstActivity.utils;

namespace FirstActivity.Views
{
    public class Ex2
    {
        private const double DOLAR_VAR = 5.17, EURO_VAR = 6.14, PESO_VAR = 0.05;
        public static void runExercise()
        {
            Console.WriteLine("\nExercise 2:");
            Console.Write("\nEnter the value in R$: ");
            double real = Convert.ToDouble(Console.ReadLine());
            string dolar = money.convertToString(real / DOLAR_VAR),
                euro = money.convertToString(real / EURO_VAR),
                peso = money.convertToString(real / PESO_VAR);
            Console.WriteLine($"US$ { dolar } - EUR { euro } - $ { peso }");
        }
    }
}