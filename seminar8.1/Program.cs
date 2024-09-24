namespace seminar8._1
{
    //Доработайте реализацию калькулятора разработав собственные типы ошибок.
    //CalculatorDivideByZeroException, CalculateOperationCauseOverflowException


    //Реализуйте класс - список, описывающий последовательность действий приведших исключению.
    //Очевидно что класс калькулятора должен быть доработан чтобы хранить не только информацию 
    //необходимую нам для отмены но и информацию о самом действии.




    internal class Program
    {
        static void Calculator_GotResult(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Calculator)sender).Result}");
        }

        static void Execute(Action<int> action, int value = 10)
        {
            try
            {
                action.Invoke(value);
            }
            catch (CalculatorDivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (CalculateOperationCauseOverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            calculator.GotResult += Calculator_GotResult;

            Execute(calculator.Sum, int.MaxValue);
            Execute(calculator.Sum, int.MaxValue);
            Execute(calculator.Divide, 0);
            Execute(calculator.Multiply);
            Execute(calculator.Subtract, int.MaxValue);
            Execute(calculator.Subtract, int.MaxValue);
            
            
            
            
        }
    }
}
