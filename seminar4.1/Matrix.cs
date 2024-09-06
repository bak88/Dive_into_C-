using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4._1
{
    internal class Matrix<T> : IMatrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int column)
        {
            matrix = new T[rows, column];
        }

        public T this[int row, int column] 
        { 
            get => matrix[row, column];
            set => matrix[row, column] = value; 
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
