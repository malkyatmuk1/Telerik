using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.Binary_to_decimal
{
    class Program
    {
        static long Converte(string number)
        {
           long convert = 0;
  
           long[] a = new long[number.Length];
           for (int i = 0 ; i < number.Length ; i++)
           {
               a[i] = Convert.ToInt32(number[i]-48);
           }
            int k=0;
            
           long ikrai = number.Length;
            for(long i=ikrai-1 ; i>=0 ; i--)
            {
                convert += (a[i] * (long) Math.Pow(2, k));
                k++;
            }
           
            return convert;
        }
        static void Main(string[] args)
        {
            string number =Console.ReadLine();
            Console.WriteLine(Converte(number));


        }
    }
}
