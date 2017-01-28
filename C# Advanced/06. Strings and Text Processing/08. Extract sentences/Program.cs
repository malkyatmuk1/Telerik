using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_sentences
{
    class Program
    {

        static bool Isletter(char symbol)
        {
            bool iz;
            if((symbol>97 && symbol<122) || (symbol>65 && symbol<90))  iz=false;
            else iz=true;
            return iz;
        }
        static string Newstring(string whatwesearch, string text)
        {
            string newstring = "";
            string[] arr = text.Split('.');
            int index = 0;
            int length = arr[0].Length;
            for (int i = 0; i < arr.Length; i++)
            {
                length = arr[i].Length;
                string neone = arr[i];
                index = 0;
                while (true)
                {
                    index = neone.IndexOf(whatwesearch);
                    string neone1 = neone;

                    if (index == -1) break;

                    neone = neone.Remove(0, index + whatwesearch.Length);

                    if (Isletter(neone1[whatwesearch.Length + index]) && ( index == 0 || Isletter(neone1[index - 1])))
                    {
                        string a = arr[i];
                        if (a[0] == ' ' && newstring == "") { a = arr[i].Remove(0, 1); }
                        newstring = newstring + a + '.';
                        break;
                    }
                }
            }
            
            return newstring;
        }

        static void Main(string[] args)
        {
            string whatwesearch = Console.ReadLine();
            string text = Console.ReadLine();
            Console.WriteLine(Newstring(whatwesearch, text));

        }
    }
}
