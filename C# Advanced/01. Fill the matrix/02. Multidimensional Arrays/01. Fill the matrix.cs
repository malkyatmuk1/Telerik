using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            char symbol = char.Parse(Console.ReadLine());
            int br = 1;
            if (symbol == 'a')
            {
                for (int col = 0; col < n; col++)
                    for (int row = 0; row < n; row++)
                    {
                        arr[row, col] = br;
                        br++;
                    }

            }
            int direction = 1;
            if (symbol == 'b')
            {

                for (int col = 0; col < n; col++)
                {
                    if (direction == 1)
                    {

                        for (int row = 0; row < n; row++)
                        {
                            arr[row, col] = br;
                            br++;
                        }
                        direction = 0;
                        continue;
                    }

                    if (direction == 0)
                    {

                        for (int row1 = n - 1; row1 >= 0; row1--)
                        {
                            arr[row1, col] = br;
                            br++;
                        }
                        direction = 1;


                    }

                }
            }
            int last = n - 1;

            if (symbol == 'c')
            {
                int row = n - 1;
                int col = 0;
                for (int i = 0; i < ((n * n) - n) / 2 - 1; i++)
                {

                    arr[row, col] = br;
                    if (row == n - 1 && col == 0) { row = row - 1; br++; arr[row, col] = br; }
                    br++;
                    if (col == 0 && row != n - 1) last = row;
                    row++;
                    col++;

                    if (row > n - 1) { col = 0; row = last - 1; }
                }
                row = 0;
                col = 0;
                for (int i = 0; i < n; i++)
                {
                    arr[row, col] = br;
                    br++;
                    row++;
                    col++;
                }
                row = 0;
                col = 1;
                last = 1;
                for (int i = 0; i < ((n * n) - n) / 2; i++)
                {
                    arr[row, col] = br;
                    if (col == n - 1 && row == 0)
                    {

                        arr[row, col] = br;
                        break;

                    }
                    if (row == 0) last = col;


                    br++;

                    if (col == n - 1) { row = 0; col = last + 1; col--; row--; }
                    row++;
                    col++;



                }
            }
            if (symbol == 'd')
            {
                int x = 0, y = 0, d = 0;
                for (int i = 1; i <= n * n; i++)
                {
                    arr[x, y] = i;
                    if (d == 0)
                    {
                        y = y + 1;
                        if (y >= n || arr[x, y] != 0) { y = y - 1; d = 1; }

                    }
                    if (d == 1)
                    {
                        x = x + 1;
                        if (x >= n || arr[x, y] != 0) { x = x - 1; d = 2; }

                    }

                    if (d == 2)
                    {
                        y = y - 1;
                        if (y < 0 || arr[x, y] != 0) { y = y + 1; d = 3; }
                    }
                    if (d == 3)
                    {
                        x = x - 1;
                        if (x < 0 || arr[x, y] != 0) { x = x + 1; d = 0; y = y + 1; }
                    }

                }

            }
            if (symbol == 'd')
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++){if(j==0)Console.Write(arr[j,i]);
                        else Console.Write(" " +arr[j, i]);}
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col == 0) Console.Write(arr[row, col]);
                        else Console.Write(" " + arr[row, col]);
                    }
                    Console.WriteLine();
                }
            }


        }
            
            
            
            }







        }

 