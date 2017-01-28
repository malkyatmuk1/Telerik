using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.One_system_to_any_other
{
    class Program
    {

        static string ConvertToAny(string number, int fromsistema ,int tosistema)
        {
            long stoinost = 0;
            long k = number.Length - 1;
            string convert = "";
            
            for (int i = 0; i < number.Length;i++ )
            {
                if (number[i] == 'A' ) stoinost = stoinost * fromsistema + 10;
                else if (number[i] == 'B') stoinost = stoinost * fromsistema + 11;
                else if (number[i] == 'C') stoinost = stoinost * fromsistema + 12;
                else if (number[i] == 'D') stoinost = stoinost * fromsistema + 13;
                else if (number[i] == 'E') stoinost = stoinost * fromsistema + 14;
                else if (number[i] == 'F') stoinost = stoinost * fromsistema + 15;
                else stoinost = stoinost * fromsistema + (number[i] - 48);
                k--;

            }

            while(stoinost!=0)
            {
                if (stoinost % tosistema == 10) convert = convert + 'A';
                else if (stoinost % tosistema == 11) convert = convert + 'B';
                else if (stoinost % tosistema == 12) convert = convert + 'C';
                else if (stoinost % tosistema == 13) convert = convert + 'D';
                else if (stoinost % tosistema == 14) convert = convert + 'E';
                else if (stoinost % tosistema == 15) convert = convert + 'F';
                else  convert = convert + (stoinost % tosistema).ToString();
                stoinost = stoinost / tosistema;
        

            }

            return convert;
        }
        static void Main(string[] args)
        {
            int fromsistema = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            
            int tosistema = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToAny(number, fromsistema, tosistema).Reverse().ToArray());
        }
    }
}
