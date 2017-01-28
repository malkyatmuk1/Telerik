using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class Program
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
        static void Unicod(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(GetEscapeSequence(text[i]));
            }

     
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Unicod(text);
            Console.WriteLine();

        }
    }
}

