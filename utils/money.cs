namespace FirstActivity.utils
{
    public class money
    {
        public static string convertToString(double value)
        {
            return string.Format("{0:0.00}", value);
        }
    }
}