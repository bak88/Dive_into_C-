namespace dz5._1
{
    internal class Program
    {
        // Доработайте приложение поиска пути в лабиринте,
        // но на этот раз вам нужно определить сколько всего выходов имеется в лабиринте

        static void Main(string[] args)
        {
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();

            int[,] labirynth1 = new int[,]
            {
                {1, 1, 1, 1, 1, 2, 1 },
                {1, 0, 0, 0, 0, 0, 2 },
                {1, 0, 1, 1, 1, 0, 1 },
                {1, 0, 0, 0, 1, 0, 2 },
                {1, 1, 0, 0, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 }
            };


            FindPath(4, 3);


            int FindPath(int i, int j)
            {
                int countExit = 0;

                Console.WriteLine(labirynth1[i, j]);

                if (labirynth1[i, j] == 0) stack.Push(new(i, j));

                while (stack.Count > 0)
                {
                    var current = stack.Pop();

                    Console.WriteLine($"{current.Item1},{current.Item2} ");

                    if (labirynth1[current.Item1, current.Item2] == 2)
                    {
                        countExit++;
                        Console.WriteLine($"----{countExit} Путь найден {current.Item1},{current.Item2} ");
                    }

                    labirynth1[current.Item1, current.Item2] = 1;

                    if (current.Item1 + 1 < labirynth1.GetLength(0)
                    && labirynth1[current.Item1 + 1, current.Item2] != 1)
                        stack.Push(new(current.Item1 + 1, current.Item2));

                    if (current.Item2 + 1 < labirynth1.GetLength(1) &&
                    labirynth1[current.Item1, current.Item2 + 1] != 1)
                        stack.Push(new(current.Item1, current.Item2 + 1));

                    if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
                        stack.Push(new(current.Item1 - 1, current.Item2));

                    if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
                        stack.Push(new(current.Item1, current.Item2 - 1));
                }

                if(countExit == 0)
                    Console.WriteLine("Exit closed");
                return countExit;
            }
        }
    }
}
