using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static int Broi(string numbers, string number)
        {
            string[] numbers1;
            int br=0;
            numbers1 = numbers.Split(' '); 
            for(int i=0;i<numbers1.Length;i++)
            {
                if (numbers1[i] == number) br++;
            }
            return br;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            string number = Console.ReadLine();
            Console.WriteLine(Broi(numbers, number));
        }
    }
}
