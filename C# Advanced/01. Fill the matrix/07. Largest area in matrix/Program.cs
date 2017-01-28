using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_area_in_matrix
{
    
    class Program
    {
        
        static int FoundAr(int y, int x,int[,] matrix,int n,int m)
        {
            int br=0;
            int current=matrix[y,x];
            matrix[y,x]=-1;
            if (y+1<n && matrix[y+1,x]==current ){
                br = br + FoundAr(y + 1, x, matrix, n, m);
            }

            if (y -1 >=0 && matrix[y-1, x] == current)
            {
                br = br + FoundAr(y - 1, x, matrix, n, m);
            }

            if (x + 1 <m && matrix[y , x+1] == current)
            {
                br = br + FoundAr(y, x+1, matrix, n, m);
            }

            if (x-1>=0 && matrix[y , x-1] == current)
            {
                br = br + FoundAr(y , x-1, matrix, n, m);
            }


            return br+1;

        }
        static void Main(string[] args)
        {
           

            // wyvejdane na purvite
             string number = Console.ReadLine();
             string[] arr = number.Split(' ');
             int n = Convert.ToInt32(arr[0]);
             int m = Convert.ToInt32(arr[1]);
            //vuvejdane na vtorite
             int[,] matrix=new int[n,m];
             string[] arr1;
             
             for (int i = 0; i < n; i++)
             {
                 arr1 = Console.ReadLine().Split(' ');
                
                 for (int j = 0; j <m ; j++)
                 {

                     matrix[i,j] = Convert.ToInt32(arr1[j]);
                 }

                 
             }
                 
             
             

             
           
            int f=0;
            int max = Int32.MinValue;
            for(int row=0;row<n; row++)
                for (int col = 0; col <m; col++)
                {
                    if (matrix[row, col] != -1) f=FoundAr(row,col,matrix,n,m);

                    if (max < f) max = f;
                }
            Console.WriteLine(max);

        }
    }
}
