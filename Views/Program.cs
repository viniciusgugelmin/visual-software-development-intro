using System;
using FirstActivity.Views;
using FirstActivity.utils;

namespace FirstActivity.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            if (args.Length > 1)
            {
                runSpecificExercise(args[1]);
                return;
            }

            // Exercise 1
            Ex1.RunExercise();
            // Clear
            Organization.ClearAfterType();
            // Exercise 2
            Ex2.RunExercise();
            // Clear
            Organization.ClearAfterType();
            // Exercise 3
            Ex3.RunExercise();
            // Clear
            Organization.ClearAfterType();
            // Exercise 4
            Ex4.RunExercise();
            // Clear
            Organization.ClearAfterType();
            // Exercise 5
            Ex5.RunExercise();
            // Clear
            Organization.ClearAfterType();
            // Exercise 6
            Ex6.RunExercise();
            // Clear
            Organization.ClearAfterType(true);
        }

        static void runSpecificExercise(string value)
        {
            switch (value)
            {
                case "1":
                    Ex1.RunExercise();
                    break;
                case "2":
                    Ex2.RunExercise();
                    break;
                case "3":
                    Ex3.RunExercise();
                    break;
                case "4":
                    Ex4.RunExercise();
                    break;
                case "5":
                    Ex5.RunExercise();
                    break;
                case "6":
                    Ex6.RunExercise();
                    break;
            }

            Organization.ClearAfterType(true);
        }
    }
}
