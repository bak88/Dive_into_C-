namespace lecture6._2
{
    internal class Program
    {

        //Дан список целых чисел(числа не последовательны), в котором некоторые числа повторяются.
        //Выведите список чисел на экран, расположив их в порядке возрастания частоты повторения,
        //а после убывания

        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0, 2 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in ints)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            var sort = dict.OrderBy(x => x.Value);

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var sortDisc = dict.OrderByDescending(x => x.Value);

            foreach (var item in sortDisc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
