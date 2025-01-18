using System.Linq;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

        public static string RepeatString(this string str, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
