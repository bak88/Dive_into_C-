namespace seminar7._1
{
    internal class Program
    {

        //Спроектируем интерфейс калькулятора, поддерживающего простые арифметические действия, 
        //хранящего результат и также способного выводить информацию о результате при помощи события

        static void Calculator_GotResult(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Calculator)sender).Result}");
        }

        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            calculator.GotResult += Calculator_GotResult;

            calculator.Sum(2);
            calculator.Sum(3);
            calculator.CancelLast();
            calculator.Sum(4);

        }
    }
}
