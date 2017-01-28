using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixM;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> firstMatrix = new Matrix<int>(2,2);
            Matrix<int> secondMatrix = new Matrix<int>(2,2);
            Matrix<int> trueMatrix = new Matrix<int>(2, 2);
            
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    firstMatrix[i, j] = count;
                    trueMatrix[i, j] = 0;
                    count++;
                    secondMatrix[i, j] = count;
                    count++;
                }
            }
            Console.WriteLine(firstMatrix);
            Console.WriteLine();
            Console.WriteLine(secondMatrix);
            Console.WriteLine();
            Matrix<int> resultMatrix = new Matrix<int>(firstMatrix.Row,firstMatrix.Col);
            
            resultMatrix = firstMatrix + secondMatrix;
            Console.WriteLine(resultMatrix);
            Console.WriteLine();
            Matrix<int> supMatrix = new Matrix<int>(firstMatrix.Row, firstMatrix.Col);
            supMatrix = firstMatrix - secondMatrix;
            Console.WriteLine(supMatrix);
            Console.WriteLine();
            Matrix<int> mulMatrix = new Matrix<int>(firstMatrix.Row, firstMatrix.Col);
            mulMatrix = firstMatrix * secondMatrix;
            Console.WriteLine(mulMatrix);
            if (secondMatrix) Console.WriteLine("I'm right!");
            else Console.WriteLine("I'm false !");
            
            
        }
    }
}
