namespace FirstActivity.utils
{
    public class Money
    {
        public static string ConvertToString(double value)
        {
            return string.Format("{0:0.00}", value);
        }
    }
}