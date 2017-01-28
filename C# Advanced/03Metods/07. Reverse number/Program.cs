using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static void Reverse(string number)
        {
           
         
            for (int i =number.Length-1; i >=0;i--)
            {
                Console.Write(number[i]);

            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Reverse(number);
        }
    }
}
