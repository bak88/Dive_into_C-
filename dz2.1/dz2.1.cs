namespace dz2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the array: "); // Введите ширину массива
            int widthArr = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the height of the array: "); // Введите высоту массива
            int heightArr = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            int[,] matrix = FillMatrix(widthArr, heightArr);
            PrintMatrix(matrix);
            Console.WriteLine();
            int[] sortArr = SortArray(matrix, widthArr, heightArr);
            int[,] sortMatrix = FillNewSortMatrix(sortArr, widthArr, heightArr);
            PrintMatrix(sortMatrix);
            
        }

        static int[,] FillMatrix(int widt, int height)
        {
            int[,] matrix = new int[widt, height];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Random random = new Random();
                    matrix[i, j] = random.Next(1, 99);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[] SortArray(int[,] matrix, int widt, int height)
        {
            int[] array = new int[widt * height];
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }
            Array.Sort(array);
            return array;
        }

        static int[,] FillNewSortMatrix(int[] array,  int widt, int height)
        {
            int[,] matrix = new int[widt, height];
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[index];
                    index++;
                }
            }
            return matrix;

        }


    }
}
