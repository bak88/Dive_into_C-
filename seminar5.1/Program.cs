namespace seminar5._1
{
    // Используя стек инвертируйте порядок следования элементов в спиcке
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Stack<int> stack = FillStack(list);
            
            List<int> newList = FillList(stack);         

            Console.WriteLine(string.Join(", ", newList));
        }

        static Stack<int> FillStack(List<int> list)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int i in list)
            {
                stack.Push(i);
            }
            return stack;
        }

        static List<int> FillList(Stack<int> stack)
        {
            List<int> list = new List<int>();

            foreach (var item in stack)
            {
                list.Add(item);
            }
            return list;

        }
    }
}
