using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class Program
    {
        static int GetMax(int number1, int number2)
        {
            int max = 0;
            if (number1 > number2) max = number1;
            else max = number2;
            return max;

        }
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] a = new int[3];
            for (int i = 0; i < 3; i++)
            {
                a[i] = Convert.ToInt32(arr[i]);
            }
            int number1 = a[0];
            int number2=a[1];
            int number3 = a[2];
           
            int max=0;
            max = GetMax(number1, number2);
            if (max < GetMax(number1, number3)) max = GetMax(number1, number3);
            else  if (max < GetMax(number2, number3)) max = GetMax(number2, number3);
            Console.WriteLine(max);
        }
    }
}
