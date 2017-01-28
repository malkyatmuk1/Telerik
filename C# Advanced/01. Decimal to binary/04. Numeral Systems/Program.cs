using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numeral_Systems
{
    class Program
    {
        static string Convert(long number)
        {
           string convert="";

           int i = 0;
            while(number!=0)
            {
                if (number % 2 == 0) convert = convert + "0";
                else convert = convert + "1";
                number = number / 2;
             }
            return convert;

        }
        static void Main(string[] args)
        {
            long number=long.Parse(Console.ReadLine());
            Console.WriteLine(Convert(number).Reverse().ToArray());
        }
    }
}
