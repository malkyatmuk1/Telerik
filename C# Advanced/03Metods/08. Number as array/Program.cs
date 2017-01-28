using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_array
{
    class Program
    {
        static string NumbersasAr(string arr, string arr1)
        {
            string krai = "";
            byte cary = 0;
            byte chislo = 0;
            byte a,b;
            ushort i = 0;
            ushort j = 0;
            while(i<arr.Length || j<arr1.Length || cary!=0)
            {
                if (krai != "") krai = krai + ' ';
                if(i<arr.Length){
                    a = (byte)(arr[i]-'0');
                   
                }
                else a=0;
                if(j<arr1.Length)
                {
                    b =  (byte)(arr1[i] - '0');
                }
                else b=0;
               
                chislo =(byte) (a + b + cary);
                krai = krai + (chislo % 10).ToString();
                cary = (byte)(chislo / 10);
                i=(ushort)(i+2);
                j = (ushort)(j + 2);
            }
            
            return krai;

        }
        static void Main(string[] args)
        {
            string broi = Console.ReadLine();
            string numbers = Console.ReadLine();
            string numbers1 = Console.ReadLine();
            
           Console.WriteLine( NumbersasAr(numbers, numbers1));

        }
    }
}
