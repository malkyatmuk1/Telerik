using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class Program
    {
        static string Letters(string text)
        {
            int i=0;
            string newone="";
            while (i != text.Length-1)
            {
                if (text[i] != text[i + 1]) newone = newone + text[i];
                i++;
            }
            newone = newone + text[text.Length - 1];
            return newone;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Letters(text));
        }
    }
}
