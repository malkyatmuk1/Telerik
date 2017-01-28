using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int br=0,br1=0;
            string str = Console.ReadLine();
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == ')') br++;
                if (str[i] == '(') br1++;
            }
            if (br1==br) Console.WriteLine("Correct");
            else Console.WriteLine("Incorrect");
            
        }
    }
}
