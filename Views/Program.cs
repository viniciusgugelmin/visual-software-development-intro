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

            if (args.Length > 1) {
                runSpecificExercise(args[1]);
                return;
            }
         
            // Exercise 1
            Ex1.runExercise();
            // Clear
            organization.clearAfterType();
            // Exercise 2
            Ex2.runExercise();
            // Clear
            organization.clearAfterType();
            // Exercise 3
            Ex3.runExercise();
            // Clear
            organization.clearAfterType();
            // Exercise 4
            Ex4.runExercise();
            // Clear
            organization.clearAfterType();
            // Exercise 5
            Ex5.runExercise();
            // Clear
            organization.clearAfterType();
            // Exercise 6
            Ex6.runExercise();
            // Clear
            organization.clearAfterType(true);
        }

        static void runSpecificExercise(string value)
        {
            switch (value) {
                case "1":
                    Ex1.runExercise();
                    break;
                case "2":
                    Ex2.runExercise();
                    break;
                case "3":
                    Ex3.runExercise();
                    break;
                case "4":
                    Ex4.runExercise();
                    break;
                case "5":
                    Ex5.runExercise();
                    break;
                case "6":
                    Ex6.runExercise();
                    break;
            }
        }   
    }
}
