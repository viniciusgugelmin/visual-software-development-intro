using System;

namespace FirstActivity.Views
{
    public class Ex4
    {
        public static void runExercise()
        {
            Console.WriteLine("\nExercise 4:");
            Console.Write("\nEnter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            string ageResult = "Elderly";
            if (age <= 13)
            {
                ageResult = "Kid";
            }
            else if (age > 14 && age <= 18)
            {
                ageResult = "Teenager";
            }
            else if (age > 18 && age <= 60)
            {
                ageResult = "Adult";
            }
            Console.WriteLine($"{ ageResult }");
        }
    }
}