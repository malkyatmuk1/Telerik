using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class Program
    {
        static string LastDigit(string word)
        {
            string last="";
            int n = word.Length - 1;

            if (word[n] == '1') last = "one";
            if (word[n] == '2') last = "two";
            if (word[n] == '3') last = "three";
            if (word[n] == '4') last = "four";
            if (word[n] == '5') last = "five";
            if (word[n] == '6') last = "six";
            if (word[n] == '7') last = "seven";
            if (word[n] == '8') last = "eight";
            if (word[n] == '9') last = "nine";
            if (word[n] == '0') last = "zero";
            return last;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(LastDigit(number));
        }
    }
}
