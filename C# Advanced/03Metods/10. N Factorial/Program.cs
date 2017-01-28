using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static  BigInteger Fact(int number)
        {
           BigInteger fac = 1;
            for (int i = 1; i <= number; i++)
                fac = fac * i;

                return fac;
        
        }
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            Console.WriteLine(Fact(number));
        }
    }
}
