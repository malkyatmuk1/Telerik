using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static string ConvertFromBinToDec(string number)
        {
            long stoinost = 0;
            int stepen=number.Length-1;
            for(int i=0;i<number.Length;i++)
            {
                stoinost = stoinost +((int) number[i] - 48)*(long)Math.Pow(2,stepen);
                stepen--;
            }
            string convert = "";
            while (stoinost != 0)
            {
                if (stoinost % 16 == 10) convert = convert + "A";
                else if (stoinost % 16 == 11) convert = convert + "B";
                else if (stoinost % 16 == 12) convert = convert + "C";
                else if (stoinost % 16 == 13) convert = convert + "D";
                else if (stoinost % 16 == 14) convert = convert + "E";
                else if (stoinost % 16 == 15) convert = convert + "F";
                else convert = convert + (stoinost % 16).ToString();
                stoinost=stoinost / 16;
            }
            return convert;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ConvertFromBinToDec(number).Reverse().ToArray());
        }
    }
}
