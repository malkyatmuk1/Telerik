namespace Longest_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestProgram
    {
        public static string LongestString(string[] arr)
        {
            int max=arr[0].Length;

            var str = arr.OrderByDescending(s => s.Length).First();
            return str;
                        
        }
        static void Main(string[] args)
        {
            string[] arr = new string[] { "ivanka", "ico", "mama", "kakabaka" };
            Console.WriteLine(LongestString(arr));
        }
    }
}
