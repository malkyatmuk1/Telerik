using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static string ConvertToHex(long number)
        {

            string convert = "";
            while(number!=0)
            {
                if (number % 16 == 10) convert = convert + "A";
                else if (number % 16 == 11) convert = convert + "B";
                else if (number % 16 == 12) convert = convert + "C";
                else  if (number % 16 == 13) convert = convert + "D";
                else if (number % 16 == 14) convert = convert + "E";
                else if (number % 16 == 15) convert = convert + "F";
                else convert = convert + (number % 16).ToString();
                number = number / 16;
            }
            return convert;


        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

           
            Console.WriteLine(ConvertToHex(number).Reverse().ToArray());
        }
    }
}
