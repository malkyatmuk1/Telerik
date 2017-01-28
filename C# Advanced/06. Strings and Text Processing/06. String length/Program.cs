using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class Program
    {
        static string Lenth(string text)
        {
            for (int i = text.Length; i <20 ;i++ )
                text = text.Insert(text.Length , "*");
            return text;

        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Lenth(text));
        }
    }
}
