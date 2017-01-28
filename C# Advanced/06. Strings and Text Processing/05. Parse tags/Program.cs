using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
        static string Upper(string text)
        {
            int index,index2;
            string text1 = text;
            while (index != -1 && index2 != -1) 
            {
                index = text.IndexOf("<upcase>");
                index2 = text.IndexOf("</upcase>");
                string str1 = text.Substring(index + 7, index2 - 1);
                 str1=str1.ToUpper();
                 text = text.Delete(index + 8, str1.Length);
                 text = text.Insert(index + 8, str1);
                 text = text.Delete(index1, 8);
                 text = text.Delete(index, 8);

                }
                           
            return text;
        }
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            Console.WriteLine(Upper(text));

        }
    }
}
