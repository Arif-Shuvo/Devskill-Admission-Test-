using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = "aaabbcc";
            var result = text.Rotate(2);
            Console.WriteLine(result);
        }
    }

    /* Write your code below this line*/
    public static class RotateString
    {
        public static string Rotate(this String str, int count)
        {
            int len = str.Length;
            if (len == count)
            {
                return str;
            }
            else
            {
                if (len < count)
                {
                    count = count - len;
                }

                for (int i = 0; i < count; i++)
                {
                    var last = str[len - 1].ToString();

                    str = str.Remove(len - 1);

                    str = str.Insert(0, last);
                }
            }

            return str;
        }
    }
}
