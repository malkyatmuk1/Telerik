﻿namespace MatrixM
{
    using System;
    using System.Text;
    class Matrix<T>
    {
        public int row;
        public int col;
            public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                if (value < 0) throw new IndexOutOfRangeException("invalid index-row!");
                else this.row = value;
            }
        }

        public int Col {
            get 
            {
                return this.col;
            }
       
            set 
            {
                if (value < 0) throw new IndexOutOfRangeException("invalid index-col!");
                else this.col = value;
            }
        }
        public T[,] TheMatrix { get; set; }

        
        public Matrix(int row,int col)
        {
            this.Row = row;
            this.Col = col;
            this.TheMatrix = new T[row,col];
        }
        public T this[int row,int col]
        {
            get
            {
                return this.TheMatrix[row, col];
            }
            set 
            {
                if (row < 0 || row > this.Row || col < 0 || col > this.Col) throw new IndexOutOfRangeException("invalid index!");
                else this.TheMatrix[row,col] = value;

            }
        }
        
        public static  Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)  
        {  
            dynamic sum=0;
            if( matrix1.Row!=matrix2.Row || matrix1.Col != matrix2.Col) throw new ArgumentException("the row and the col of the two matrixes must the same !");
            Matrix<T> result = new Matrix<T>(matrix1.Row,matrix1.Col);
            for(int i=0;i<matrix1.Row;i++)
                for(int j=0;j<matrix1.Col;j++)
                {
                   
                     result[i, j] =(dynamic)matrix1[i, j] + matrix2[i, j];
                }


             return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            dynamic sub = 0;
            if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col) throw new ArgumentException("the row and the col of the two matrixes must the same !");
           Matrix<T> result = new Matrix<T>(matrix2.Row, matrix2.Col);
            for (int i = 0; i < matrix1.Row; i++)
                for (int j = 0; j < matrix1.Col; j++)
                {
                    result[i, j] = (dynamic) matrix1[i, j] - matrix2[i, j];
                    
                }


            return result;
        }
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            dynamic mul = 1;
            if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col) throw new ArgumentException("the row and the col of the two matrixes must the same !");
            Matrix<T> result = new Matrix<T>(matrix2.Row, matrix2.Col);
            for (int i = 0; i < matrix1.Row; i++)
                for (int j = 0; j < matrix1.Col; j++)
                {
                    mul = (dynamic) matrix1[i, j] * matrix2[i, j];
                    result[i, j] = mul;
                }


            return result;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            int br=0;
            for (int  i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == default(T)) return false; 
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            int br = 0;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == 0) return false;
                }
            }
            return true;
            
        }
        public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            for (int i = 0; i <this.Row ; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    stroitel.Append(this.TheMatrix[i,j]).Append(" ");
                    if(j%2!=0 && i != this.Row-1)stroitel.AppendLine();
                }
                
            }
            return stroitel.ToString();

        }
       
    }
}
