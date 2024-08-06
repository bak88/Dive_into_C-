namespace dz2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the array"); // Введите ширину массива
            int widthArr = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter the height of the array"); // Введите высоту массива
            int heightArr = int.Parse(Console.ReadLine()!);

            int[,] matrix = FillMatrix(widthArr, heightArr);
            PrintMatrix(matrix);
            SortArray(matrix, widthArr, heightArr);
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
            Console.WriteLine(string.Join(", ", array));

            return array;
        }


    }
}
