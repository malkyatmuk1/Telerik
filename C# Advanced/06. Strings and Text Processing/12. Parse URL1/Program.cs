using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL1
{
    class Program
    {
        static string GetProtocol(string text)
        {
            int index = text.IndexOf(':');
            string protocol = text.Substring(0, index);
            return protocol;
        }
        static string GetServer(string text)
        {
            int index= text.IndexOf(':');
            text = text.Remove(0, index + 3);
             int index2=text.IndexOf('/');
            string server = text.Substring(0, index2);
            return server;
        }
        static string GetResource(string text)
        {
            int index = text.IndexOf(':');
            text = text.Remove(0, index + 3);
            int index2 = text.IndexOf('/');
            text = text.Remove(0, index2 );
            return text;


        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine("[protocol] = " + GetProtocol(text));
            Console.WriteLine("[server] = " + GetServer(text));
            Console.WriteLine("[resource] = " + GetResource(text));
        }
    }
}
