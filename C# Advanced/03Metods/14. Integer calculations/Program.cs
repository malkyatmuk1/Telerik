using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static int Max(string numbers)
        {
            int max =Int32.MinValue;
            string[] arr = numbers.Split(' ');
            int[] a = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                a[i] = Convert.ToInt32(arr[i]);
                if (max<a[i]) max = a[i];
            }
            return max;

        }
        static int Min(string numbers)
        {
            int min = Int32.MaxValue;
            string[] arr = numbers.Split(' ');
            int[] a = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                a[i] = Convert.ToInt32(arr[i]);
                if (min > a[i]) min = a[i];
            }
            return min;
        }
        static long Sum(string numbers)
        {
            long sum =0;
            string[] arr = numbers.Split(' ');
            long[] a = new long[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                a[i] = Convert.ToInt32(arr[i]);
                sum = sum + a[i];
            }
            return sum;

        }
        static long Pro(string numbers)
        {
            long pro =1;
            string[] arr = numbers.Split(' ');
            long[] a = new long[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                a[i] = Convert.ToInt32(arr[i]);
                pro= pro * a[i];
            }
            return pro;

        }
        static float Av(string numbers)
        {
            float sum = 0;
            string[] arr = numbers.Split(' ');
            long[] a = new long[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                a[i] = Convert.ToInt32(arr[i]);
                sum = sum + a[i];
            }
            
            return sum/arr.Length;

        }

        static void Main(string[] args)
        {
            string numbers=Console.ReadLine();
            Console.WriteLine(Min(numbers));
            Console.WriteLine(Max(numbers));
            Console.WriteLine((Av(numbers).ToString("0.00")));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Pro(numbers));
      



        }
    }
}
