namespace lecture2._6_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = @"C:\document\file.txt";
            string str2 = "C:\\document\\file.txt";
            string str3 = """ THis is a "raw" str""";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine();

            //Compare(параметры) - ряд перегруженных методов, позволяющих
            //сравнивать две строки.Метод используется при сортировке массивов и
            //списков строк. Функция возвращает
            //0, если строки равны;
            //-1, если первая строка предшествует второй в порядке сортировки;
            //1, если вторая строка предшествует первой.

            string str4 = "aaaa";
            string str5 = "AAAA";
            int res4 = String.Compare(str4, str5, StringComparison.CurrentCultureIgnoreCase);
            int res5 = String.Compare(str4, str5);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine();


            //Concat(параметры) - ряд перегруженных методов, позволяющих
            //сконструировать и вернуть новую строку из переданных в качестве
            //параметра.

            str4 = "aaaa";
            str5 = "AAAA";
            string res = String.Concat(str4, str5);
            Console.WriteLine(res);
            Console.WriteLine();


            //Contains(параметры) - ряд перегруженных методов, позволяющих
            //определить, содержит ли строка определенную подстроку.Как и в функции
            //сравнения строк, вы можете указать различные параметры сравнения.

            str3 = "First Second";
            str4 = "Sec";
            str5 = "Third";
            bool res1 = str3.Contains(str4);
            bool res2 = str3.Contains(str5);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine();


            //EndsWith(параметры) - ряд перегруженных методов, позволяющих
            //определить, заканчивается ли строка искомым символом либо подстрокой.

            str3 = "First Second";
            str4 = "st Second";
            char ch = 'd';
            res1 = str3.EndsWith(str4);
            res2 = str3.EndsWith(ch);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine();


            //Format(параметры) - ряд перегруженных методов, позволяющих задать
            //шаблон строки и значения, которые мы хотим подставить в этот шаблон.

            int num1 = 1;
            str3 = "three";
            decimal dec1 = 3.0M;
            res = String.Format("num1={0}, str3={1}, dec1={2}", num1, str3, dec1);
            Console.WriteLine(res);
            Console.WriteLine();


            //IndexOf(параметры) - ряд перегруженных методов, возвращающих позицию
            //заданной подстроки в строке(строки как и массивы индексируются с нуля).
            //В случае, если подстрока не найдена, функция возвращает -1.

            str3 = "onr two three";
            str4 = "two";
            str5 = "four";
            res4 = str3.IndexOf(str4);
            res5 = str3.IndexOf(str5);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine();


            //Insert(параметры) - возвращает строку, в которой заданная подстрока
            //вставлена в указанную позицию.

            str3 = "onr two three";
            str4 = " four";
            res = str3.Insert(str3.Length, str4);
            Console.WriteLine(res);
            Console.WriteLine();


            //IsNullOrEmpty(параметр) - функция возвращает true, если строка
            //переданная в нее пустая или равняется null.

            str3 = "onr two three";
            str4 = null;
            res1 = String.IsNullOrEmpty(str3);
            res2 = String.IsNullOrEmpty(str4);
            Console.WriteLine(res1);
            Console.WriteLine(res2);

        }
    }
}
