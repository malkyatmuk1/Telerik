namespace Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

 public static class ClassExtentions
    {
        public static void PrintNumbers(int[] arr)
        {
            foreach (var numbers in arr)
            {
                Console.Write(numbers+" ");
            }
            Console.WriteLine();
        }

        public static void Divisible(this List<int> numbers)
        {
            var num = numbers.Where(n => n % 7 == 0 && n % 3 == 0).ToArray();
            PrintNumbers(num);

        }
    }
}
