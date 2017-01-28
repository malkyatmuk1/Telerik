using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static string ConvertToBin(string number)
        {
            string convert = "";
            long stoinost = 0;
            int k = number.Length - 1;
            int stoi;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 'A') stoinost = stoinost + (long)(10 * Math.Pow(16, k));
                else if (number[i] == 'B') stoinost = stoinost + (long)(11 * Math.Pow(16, k));
                else if (number[i] == 'C') stoinost = stoinost + (long)(12 * Math.Pow(16, k));
                else if (number[i] == 'D') stoinost = stoinost + (long)(13 * Math.Pow(16, k));
                else if (number[i] == 'E') stoinost = stoinost + (long)(14 * Math.Pow(16, k));
                else if (number[i] == 'F') stoinost = stoinost + (long)(15 * Math.Pow(16, k));
                else
                {
                    stoi = (number[i] - 48);
                    stoinost = stoinost + (long)(stoi * Math.Pow(16, k));
                }
                k--;
            }
          
            while (stoinost != 0)
            {
                if (stoinost % 2 == 0) convert = convert + "0";
                else convert = convert + "1";
                stoinost = stoinost / 2;
            }
            return convert;
        }

        static void Main(string[] args)
        {
            string number=Console.ReadLine();
            Console.WriteLine(ConvertToBin(number).Reverse().ToArray());
        }
    }
}
