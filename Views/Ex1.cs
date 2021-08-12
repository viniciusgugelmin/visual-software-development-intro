using System;

namespace FirstActivity.Views
{
    public class Ex1
    {
        public static void RunExercise()
        {
            Console.WriteLine("Exercise 1:");
            Console.Write("\nEnter the breadth of the rectangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the retangle: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int a = b * l;
            Console.WriteLine($"b x l = { b } x { l } = { a }");
        }
    }
}