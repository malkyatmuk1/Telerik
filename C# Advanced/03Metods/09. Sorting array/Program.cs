using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {
        static void Sort(string numbers)
        {
            string[] arr = numbers.Split(' ');
            int[] a = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                a[i] = Convert.ToInt32(arr[i]);
            }
            int br = 1;
            int b = 0;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = br; i < arr.Length; i++)
                {
                    if (a[j] > a[i]) { b = a[i]; a[i] = a[j]; a[j] = b; }
                }
                br++;
            }

            for (int i = 0; i <= arr.Length - 2; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine(a[arr.Length - 1]);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            Sort(numbers);
        }
    }
}
