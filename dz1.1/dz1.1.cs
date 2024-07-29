namespace dz1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, 
            //введенные из командной строки, и выводящую результат выполнения на экран.

            if (args.Length == 3)
            {
                int number1 = int.Parse(args[0]);
                int number2 = int.Parse(args[2]);
                int result = 0;

                switch (args[1])
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"{number1} + {number2} = {result}");
                        return;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"{number1} - {number2} = {result}");
                        return;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"{number1} * {number2} = {result}");
                        return;
                    case "/":
                        if (number2 == 0)
                        {
                            throw new Exception("You can't divide by zero"); // Деление на ноль невозможно
                        }
                        else
                        {
                            result = number1 / number2;
                            Console.WriteLine($"{number1} / {number2} = {result}");
                            return;
                        }
                    default:
                        Console.WriteLine("Unable to perform operation"); // Невозможно выполнить операцию
                        return;
                }


            }
            else if (args.Length <= 2 || args.Length >= 4)
            {
                Console.WriteLine("Incorrect number of arguments entered"); // Введено не верное количество аргументов
            }
        }
    }
}
