using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static int Larger(string numbers)
        {
            string[] number = numbers.Split(' ');
            int[] number2=new int [number.Length];
            int br = 0;
            for (int i = 1; i < number2.Length-1;i++ )
            {
                number2[i-1] = Convert.ToInt32(number[i-1]);
                number2[i] = Convert.ToInt32(number[i]);
                number2[i+1] = Convert.ToInt32(number[i+1]);

                if (number2[i] > number2[i + 1] && number2[i]>number2[i-1]) br++;
            }
                return br;
        }
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            Console.WriteLine(Larger(numbers));
        }

    }
}
