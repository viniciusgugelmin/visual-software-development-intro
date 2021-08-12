using System;

namespace FirstActivity.utils
{
    public class Numbers
    {
        public static void GetFibonacciSequence(int number)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            if (number == 0 || number == 1)
            {
                Console.WriteLine(number);
                return;
            }

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            for (int i = 0; result < number; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;

                if (result <= number)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}