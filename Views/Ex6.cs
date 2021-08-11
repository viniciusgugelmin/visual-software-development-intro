using System;

namespace FirstActivity.Views
{
    public class Ex6
    {
        public static void runExercise()
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
    }
}