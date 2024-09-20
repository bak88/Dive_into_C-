namespace lecture8._1
{
    internal class Program
    {
        static int DivideTwoNumber(int a, int b)
        {
            return a / b;

        }

        static int[] DivideTwoArray(int[] a, int[] b)
        {
            int[] res = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                res[i] = a[i] / b[i];
            }
            return res;
        }

        static void RunDivideTwoArray(int[] a, int[] b)
        {
            try
            {
                var res = DivideTwoArray(a, b);
                foreach (var item in res)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(" Арифметическая ошибка");
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine(" Ошибка деления на ноль");                    
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(" Ошибка длинны массива");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Не могу обработать ошибку");
                Console.WriteLine(ex);
                throw ex;
            }
            
        }


        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine(DivideTwoNumber(1, 0));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error divide by zero " + e);

            //}





            //AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            //{
            //    Console.WriteLine("---------Возможно исключение: " + eventArgs.Exception);
            //};

            //AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
            //{
            //    Console.WriteLine("---------Программа не обработала исключение: " + eventArgs.ExceptionObject);
            //};








            //RunDivideTwoArray(new int[] { 8, 2, 4 }, new int[] { 2, 2 });
            //RunDivideTwoArray(new int[] { 8, 2, 4 }, new int[] { 0, 2, 2 });
            // RunDivideTwoArray(null, new int[] { 2, 2, 2 });
            


            throw new Exception("Демонстрация сообщения об ошибке");




        }
    }
}



