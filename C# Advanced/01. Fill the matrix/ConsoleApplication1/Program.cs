using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a;
       

            int[,] arr = new int[n, n];
            int x = 0, y = 0, d = 0;
            for (int i = 1; i <= n * n; i++)
            {
                arr[x, y] = i;
                if (d == 0)
                {
                    y = y + 1;
                    if (y >=n || arr[x, y] != 0) { y = y - 1; d = 1; }

                }
                if (d == 1)
                {
                    x = x + 1;
                    if (x >= n || arr[x, y] != 0) { x = x - 1; d = 2; }

                }

                if (d == 2)
                {
                    y = y - 1;
                    if (y < 0 || arr[x, y] != 0) { y = y + 1;d = 3;   }
                }
                if (d == 3)
                {
                    x = x - 1;
                    if (x < 0 || arr[x, y] != 0) { x = x + 1; d = 0; y = y + 1; }
                }
               

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write(arr[j, i] + " ");
                Console.WriteLine();
            }

        }
    }
}

