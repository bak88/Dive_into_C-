namespace seminar5._3
{
    //Есть лабиринт описанный в виде двумерного массива где 1 это стены, 0 - проход, 2 - искомая цель.
    //Пример лабиринта:
    //1 1 1 1 1 1 1
    //1 0 0 0 0 0 1
    //1 0 1 1 1 0 1
    //0 0 0 0 1 0 2
    //1 1 0 0 1 1 1
    //1 1 1 1 1 1 1
    //1 1 1 1 1 1 1
    //Напишите алгоритм определяющий наличие выхода из лабиринта и выводящий на экран координаты точки выхода если таковые имеются.
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();

            int[,] labirynth1 = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 2 },
                {1, 1, 0, 0, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 }
            };


            FindPath(4, 3);


            bool FindPath(int i, int j)
            {
                Console.WriteLine(labirynth1[i, j]);
                if (labirynth1[i, j] == 0) stack.Push(new(i, j));

                while (stack.Count > 0)
                {
                    var current = stack.Pop();

                    Console.WriteLine($"{current.Item1},{current.Item2} ");
                    if (labirynth1[current.Item1, current.Item2] == 2)
                    {
                        Console.WriteLine($"Путь найден {current.Item1},{current.Item2} ");
                        return true;
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

                Console.WriteLine("Пути нет");
                return false;


            }
        }
    }
}
