using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_short
{
    class Program
    {
        static string BinaryShort(ushort number)
        {
            string convert = "";
     
         int k=0; 
         
            while(k!=16)
            {
                convert = convert + (number % 2).ToString();
                number /= 2;
                k++;
            }
            
                    return convert;

            


        }
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(BinaryShort((ushort)number).Reverse().ToArray());

        }
    }
}
