using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace C_Advanced__2016_2017_1_June_2016
{
    class Program
    {
        static double Bukvi (string text1)
        {
            double sum1 = 0;
            text1 = text1.ToLower();
            for(int i=0;i<text1.Length;i++)
            {                
                sum1 = sum1 *26+(text1[i] - 97);
            }
            return sum1;
        }
        static double Vtori(string text )
        {
            double sum=0;
            for (int i = 0; i<text.Length; i++)
            {
                sum = sum * 7 + (text[i] - 48);
            }
            return sum;
        }
        static string Krai(string znak1,double sum1, double sum2)
        {
            double sum3=0;
            if (znak1 == "+") sum3 = sum1 + sum2;
            else sum3 = sum1 - sum2;
            string convert="";
            while(sum3!=0){
             convert = convert + (sum3 % 9).ToString();
             sum3 = (BigInteger)sum3/9;
            }
          
            return convert;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string znak1 = Console.ReadLine();
            string text1 = Console.ReadLine();
            Console.WriteLine(Krai(znak1,Bukvi(text),Vtori(text1)).Reverse().ToArray());
            
        }
    }
}
