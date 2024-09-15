using System.Collections;
using System.Globalization;
using System.Text;

namespace lecture6._1
{
    internal class Program
    {
        //static int[] buckets = new int[10];
        //static DictionaryEntry[] entries = new DictionaryEntry[10];
        //static int c = 1;

        //static void Add(object key, object value)
        //{
        //    int bucketNum = key.GetHashCode() & 0x7fffffff % buckets.Length;            
        //    buckets[bucketNum] = c;
        //    entries[c].Value = value;
        //    c++;
        //}

        //static object Get(object key)
        //{
        //    int bucketNum = key.GetHashCode() & 0x7fffffff % buckets.Length;
        //    return entries[buckets[bucketNum]].Value;   
        //}

        static void Main(string[] args)
        {
            //Add(5, "Element5");
            //Add(6, "Element6");

            //Console.WriteLine(Get(5));
            //Console.WriteLine(Get(6));







            //string str = "Текст с text text text словами. Выведи количество повторов вместе со словами";

            //StringBuilder sb = new StringBuilder();

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //foreach (char c in str)
            //{
            //    if (" ,.-".Contains(c))
            //    {
            //        if (sb.Length > 0)
            //        {
            //            if (dict.ContainsKey(sb.ToString()))
            //            {
            //                dict[sb.ToString()]++;
            //            }
            //            else
            //            {
            //                dict[sb.ToString()] = 1;
            //            }
            //            sb.Clear();
            //        }
            //    }
            //    else
            //    {
            //        sb.Append(c);
            //    }
            //}
            //if(dict.ContainsKey(sb.ToString()))
            //{
            //    dict[sb.ToString()]++;
            //}
            //else
            //{
            //    dict[sb.ToString() ] = 1;
            //}

            //foreach (var item in dict)
            //{
            //    Console.WriteLine($" Слово {item.Key} повторяется {item.Value} раз");
            //}







            //int[] arr = { 1, 2, 3, 44, 5, 6, 7, 8, 9, 10, 11 }; // 50

            //int target = 3;

            //HashSet<int> set = new HashSet<int>();

            //foreach (var item in arr)
            //{
            //    int res = target - item;

            //    if (set.Contains(res))
            //    {
            //        Console.WriteLine($"{res} + {item}");
            //        break;
            //    }
            //    else
            //    {
            //        set.Add(item);
            //    }
            //}






            //string[] names = { "Анна", "Алена", "Александр", "Алексей", "Елена", "Федор" };

            //IEnumerable<string> namesA = from name in names
            //                             where name.StartsWith('А')
            //                             select name;

            //foreach (string name in namesA)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine();

            //IEnumerable<string> namesB = names.Where(x => x.StartsWith('Е'));

            //names[0] = "Ержан";

            //foreach (var item in namesB)
            //{
            //    Console.WriteLine(item);
            //}





            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var ints1 = from n in ints
            //            where n % 2 == 0
            //            select
            //            new { Value = n, Pow = n * n };

            //foreach (var item in ints1)
            //{
            //    Console.WriteLine($"v={item.Value}, p={item.Pow}");
            //}

            //Console.WriteLine();

            //var ints2 = ints.Where(x => x % 2 == 0).Select(s => new { Value = s, Pow = s * s });

            //foreach(var item in ints2)
            //{
            //    Console.WriteLine($"v={item.Value}, p={item.Pow}");
            //}




            //int[] arr = { 3, 4, 12, 345, 57, 68, 080, 23 };

            //IEnumerable<int> sortRes = arr.OrderBy(x => x);

            //foreach(int i in sortRes)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //IEnumerable<int> sortDesc = arr.OrderByDescending(x => x);

            //foreach(int i in sortDesc)
            //{
            //    Console.WriteLine(i);
            //}



            int[] ints = { 1, 2, 3, 4 };

            int aggre= ints.Aggregate ((i, m) => m * i);

            Console.WriteLine(aggre);

        }
    }
}
