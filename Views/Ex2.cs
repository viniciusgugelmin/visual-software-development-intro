using System;
using FirstActivity.utils;

namespace FirstActivity.Views
{
    public class Ex2
    {
        const double DOLAR_VAR = 5.17, EURO_VAR = 6.14, PESO_VAR = 0.05;
        public static void RunExercise()
        {
            Console.WriteLine("\nExercise 2:");
            Console.Write("\nEnter the value in R$: ");
            double real = Convert.ToDouble(Console.ReadLine());
            string dolar = Money.ConvertToString(real / DOLAR_VAR),
                euro = Money.ConvertToString(real / EURO_VAR),
                peso = Money.ConvertToString(real / PESO_VAR);
            Console.WriteLine($"US$ { dolar } - EUR { euro } - $ { peso }");
        }
    }
}