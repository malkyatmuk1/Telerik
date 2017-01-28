using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static int Found(string whatwesearch, string text)
        {
            int index;
            int br=0;
            text = text.ToLower();
            whatwesearch = whatwesearch.ToLower();
            do
            {
               
                index = text.IndexOf(whatwesearch);
                if (index != -1)
                {
                    br++;
                    index = index + whatwesearch.Length;
                    text = text.Remove(0, index);
                }
            }
            while (index!=-1);
            return br;

        }
        static void Main(string[] args)
        {
            string whatwesearch = Console.ReadLine();
            string text = Console.ReadLine();
            Console.WriteLine(Found(whatwesearch, text));
            
        }
    }
}
