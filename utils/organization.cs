using System;

namespace FirstActivity.utils
{
    public class organization
    {
        public static void clearAfterType(Boolean lastOne = false)
        {
            Console.WriteLine(lastOne ? "\nFinish..." : "\nNext...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}