using System.Collections;

namespace dz7._1
{
    internal class Program
    {
        // Доработайте программу калькулятор реализовав выбор действий и вывод результатов на экран в цикле так,
        // чтобы калькулятор мог работать до тех пор пока пользователь не нажмет отмена или введёт пустую строку.

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();       

            while (true)
            {
                bool isSwitch = false;
            
                Console.Write("Enter number one: ");
                bool isRes = double.TryParse(Console.ReadLine()!, out var number);
                double num1 = number;
                if (isRes == isSwitch) return;                
                arrayList.Add(num1);

                Console.Write("Enter number two: ");
                bool isRes2 = double.TryParse(Console.ReadLine()!, out var number2);
                double num2 = number2;
                if (isRes2 == isSwitch) return;
                arrayList.Add(num2);

                Console.Write("Enter char '/' '+' '-' '*': ");
                bool isRes3 = char.TryParse(Console.ReadLine()!, out var number3);
                char num3 = number3;
                if (isRes3 == isSwitch) return;
                

                double res;

                switch (num3)
                {
                    case '/':
                        res = CalcSum(arrayList, (x, y) => x / y, Console.WriteLine);
                        arrayList.Clear();
                        continue;
                    case '*':
                        res = CalcSum(arrayList, (x, y) => x * y, Console.WriteLine);
                        arrayList.Clear();
                        continue;
                    case '+':
                        res = CalcSum(arrayList, (x, y) => x + y, Console.WriteLine);
                        arrayList.Clear();
                        continue;
                    case '-':
                        res = CalcSum(arrayList, (x, y) => x - y, Console.WriteLine);
                        arrayList.Clear();
                        continue;


                }
            }
        }

        static double CalcSum(ArrayList list, Func<double, double, double> func, Action<double> action)
        {
            double sum = func((double)list[0]!, (double)list[1]!);

            foreach (double i in list)
            {
                action(i);
            }
            Console.WriteLine(sum);
            return sum;
        }

        
    }
}
