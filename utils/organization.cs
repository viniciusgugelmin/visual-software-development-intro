using System;

namespace FirstActivity.utils
{
    public class Organization
    {
        public static void ClearAfterType(Boolean lastOne = false)
        {
            Console.WriteLine(lastOne ? "\nFinish..." : "\nNext...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}