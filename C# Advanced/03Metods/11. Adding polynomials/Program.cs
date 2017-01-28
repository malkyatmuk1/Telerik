using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static void Add1(string numbers1, string numbers2)
        {
            

            string[] arr = numbers1.Split(' ');
            string[] newone = new string[arr.Length];
            string[] arr1 = numbers2.Split(' ');
            int[] a = new int[arr.Length];
            int[] a1 = new int[arr1.Length];
            int n=0;
            if(arr1.Length>arr.Length)n=arr1.Length;
            else n=arr.Length;
            for (int i = 0; i < n; i++)
            {

                a1[i] = Convert.ToInt32(arr1[i]);

                a[i] = Convert.ToInt32(arr[i]);
                int sum = a[i] + a1[i];
                newone[i] = sum.ToString();
                
            }

            for(int i=0;i<n-1;i++)
            {
                Console.Write(newone[i]);

                Console.Write(" ");
            }
            Console.Write(newone[n - 1]);
            Console.WriteLine();


            


        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers1 = Console.ReadLine();
            string numbers2 = Console.ReadLine();
            Add1(numbers1, numbers2);

        }
    }
}
