namespace seminar5._2
{
    // Реализуйте класс с поддержкой IEnumerable<int> - CustomEnumerale который в случае использования его в следующем коде
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new CustomEnumerale())
            {
                Console.WriteLine(item);
            }
        }
    }
}
