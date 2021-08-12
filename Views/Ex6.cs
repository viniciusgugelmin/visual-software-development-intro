using System;

namespace FirstActivity.Views
{
    public class Ex6
    {
        const int MAX_VALUE = 1000;
        public static void RunExercise()
        {
            Console.WriteLine("\nExercise 6:");
            int[] arr = new int[MAX_VALUE];

            Random randNum = new Random();
            for (int i = 0; i < MAX_VALUE; i++)
            {
                arr[i] = randNum.Next(MAX_VALUE + 1);
            }

            int[] arr2 = arr;

            int aux = 0;

            for (int i = 0; i < MAX_VALUE; i++)
            {
                for (int iSort = 1; iSort < MAX_VALUE; iSort++)
                {
                    if (arr[iSort] > arr[iSort - 1])
                    {
                        aux = arr[iSort - 1];
                        arr[iSort - 1] = arr[iSort];
                        arr[iSort] = aux;
                    }
                }
            }

            Array.Sort(arr2);

            for (int i = 0; i < MAX_VALUE; i++)
            {
                Console.WriteLine($" { arr[i] } - { arr2[i] } ");
            }
        }
    }
}