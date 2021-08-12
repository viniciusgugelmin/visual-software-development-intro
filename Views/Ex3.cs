using System;

namespace FirstActivity.Views
{
    public class Ex3
    {
        public static void RunExercise()
        {
            Console.WriteLine("\nExercise 3:");
            Console.Write("\nEnter the first value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the second value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write(first > second ? $"{ first } is bigger than { second }" : (first < second ? $"{ second } is bigger than { first }" : $"{ first } is equal than { second }"));
        }
    }
}