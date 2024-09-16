namespace seminar6._1
{

    //Дан список целых чисел(числа не последовательны), в котором некоторые числа повторяются.
    //Выведите список чисел на экран, исключив из него повторы.Постарайтесь сделать задачу за O(N)

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };

            IEnumerable<int> res = ints.Distinct();

            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
