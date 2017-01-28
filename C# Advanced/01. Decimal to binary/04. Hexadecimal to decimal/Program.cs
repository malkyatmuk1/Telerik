using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static long ConvertToDec(string number)
        {
            int k=number.Length-1;
            long stoinost = 0;
            int stoi=0;
            for(int i=0;i<number.Length;i++)
            {
                if (number[i] == 'A') stoinost = stoinost + (long)(10 * Math.Pow(16, k));
                else if (number[i] == 'B') stoinost = stoinost + (long)(11 * Math.Pow(16, k));
                else if (number[i] == 'C') stoinost = stoinost + (long)(12 * Math.Pow(16, k));
                else if (number[i] == 'D') stoinost = stoinost + (long)(13 * Math.Pow(16, k));
                else if (number[i] == 'E') stoinost = stoinost + (long)(14 * Math.Pow(16, k));
                else if (number[i] == 'F') stoinost = stoinost + (long)(15 * Math.Pow(16, k));
                else
                {
                    stoi = (number[i]-48);
                    stoinost = stoinost + (long)(stoi * Math.Pow(16, k));
                }
                k--;
            }
            return stoinost;

        }
        static void Main(string[] args)
        
        {
            string number = Console.ReadLine();
            Console.WriteLine(ConvertToDec(number));
        
        }
    }
}
