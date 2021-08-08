using System;

namespace FirstActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[1] != null) {
                runExpecificExercise(args[1]);
                return;
            }
         
            Console.Clear();
            // Exercise 1
            runExerciseOne();
            // Clear
            clearAfterType();
            // Exercise 2
            runExerciseTwo();
            // Clear
            clearAfterType();
            // Exercise 3
            runExerciseThree();
            // Clear
            clearAfterType();
            // Exercise 4
            runExerciseFour();
            // Clear
            clearAfterType();
            // Exercise 5
            runExerciseFive();
            // Clear
            clearAfterType();
            // Exercise 6
            runExerciseSix();
            // Clear
            clearAfterType(true);
        }

        static void runExpecificExercise(string value)
        {
            switch (value) {
                case "1":
                    runExerciseOne();
                    break;
                case "2":
                    runExerciseTwo();
                    break;
                case "3":
                    runExerciseThree();
                    break;
                case "4":
                    runExerciseFour();
                    break;
                case "5":
                    runExerciseFive();
                    break;
                case "6":
                    runExerciseSix();
                    break;
            }
        }

        static void runExerciseOne()
        {
            Console.WriteLine("Exercise 1:");
            Console.Write("\nEnter the breadth of the rectangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the retangle: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b x l = { b } x { l } = { b * l }");
        }

        static void runExerciseTwo()
        {
            Console.WriteLine("\nExercise 2:");
            Console.Write("\nEnter the value in R$: ");
            double real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"US$ { convertToMoney(real / 5.17) } - EUR { convertToMoney(real / 6.14) } - $ { convertToMoney(real / 0.05) }");
        }

        static void runExerciseThree()
        {
            Console.WriteLine("\nExercise 3:");
            Console.Write("\nEnter the first value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the second value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write(first > second ? $"{ first } is bigger than { second }" : (first < second ? $"{ second } is bigger than { first }" : $"{ first } is equal than { second }"));
        }

        static void runExerciseFour()
        {
            Console.WriteLine("\nExercise 4:");
            Console.Write("\nEnter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            string ageResult = "Elderly";
            if (age <= 13) {
                ageResult = "Kid";
            } else if (age > 14 && age <= 18) {
                ageResult = "Teenager";
            } else if (age > 18 && age <= 60) {
                ageResult = "Adult";
            }
            Console.WriteLine($"{ ageResult }");
        }

        static void runExerciseFive()
        {
            Console.WriteLine("\nExercise 5:");
            Console.Write("\nEnter a positive int number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 0) {
                Console.Write("\nEnter a POSITIVE int number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            getFibonacciNumbers(number);
        }

        static void runExerciseSix()
        {
            Console.WriteLine("\nExercise 6:");
            int[] arr = new int[1000];

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(0, 1000);
            }

            Array.Sort(arr);

            foreach (int n in arr) {
                Console.WriteLine(n);
            }
        }

        static void getFibonacciNumbers(int number)
        {
            int firstnumber = 0, secondnumber = 1, result = 0; 

            if (number == 0 || number == 1) {
                Console.WriteLine(number);
                return;
            }

            Console.WriteLine(firstnumber);
            Console.WriteLine(secondnumber);

            for (int i = 0; result < number; i++)  
            {  
                result = firstnumber + secondnumber;  
                firstnumber = secondnumber;  
                secondnumber = result;

                if (result <= number) {
                    Console.WriteLine(result);
                }
            }
        }

        static string convertToMoney(double value)
        {
            return  string.Format("{0:0.00}", value);
        }

        static void clearAfterType(Boolean lastOne = false)
        {
            Console.WriteLine(lastOne ? "\nFinish..." : "\nNext...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
