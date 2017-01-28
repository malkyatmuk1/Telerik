using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags
{
    class Program
    {
        static string Replase(string text)
        {
            int index1=0, index2=0, index3=0;
            string result = "";
            string site = "";
           
            int i=0;
            while(true){

                if (text[i] == '<' && text[i + 1] == 'a')
                {
                    index1 = i;
                }
                if (text[i] == '"' && text[i + 1] == '>') index2 = i;
                if (index1 != 0 && index2 != 0) { 
                    site = text.Substring(index1 + 9, index2);               
                }
                if (text[i] == '<' && text[i + 1] == '/' && text[i + 2] == 'a')
                {
                    index3 = i;
                    result = text.Substring(text.Length - index3, index3 - index2 + 1);

                }

                i++;
            }
            return text;

        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Replase(text));
        }
    }
}
