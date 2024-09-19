using System.Threading.Channels;

namespace seminar7._2
{

    //Описание: Создайте метод, который принимает список чисел и функцию(делегат Func), 
    //выполняющую какую-либо операцию над числами и возвращающую результат.

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            int res = CalcSum(list, x => x % 2 == 0, (x, y) => x + y, Console.WriteLine);
        }

        static int CalcSum(List<int> list, Predicate<int> predicate, Func<int, int, int> func, Action<int> action)
        {
            int sum = 0;

            foreach (int i in list)
            {
                if(predicate(i))
                {
                    action(i);
                    sum = func(i, sum);
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
