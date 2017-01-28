using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_integers
{
    class Integer
    {
         
        
        
        public long Sum(string numbers)
        {
            string[] arr = numbers.Split(' ');
            int[] a = new int[arr.Length];
            long sum=0;
         for (int i = 0; i < arr.Length; i++)
           {

                a[i] = Convert.ToInt32(arr[i]);
                sum = sum + a[i];
            }
         return sum;
        }
}
    class Program
    {
       static void Main(string[] args)
        {
            Integer number = new Integer();
            string numbers = Console.ReadLine();
            Console.WriteLine(number.Sum(numbers));
        }
    }
}
