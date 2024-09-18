namespace dz6._1
{
    internal class Program
    {

        //Дан массив и число.Найдите три числа в массиве сумма которых равна искомому числу.
        //Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.

        static void Main(string[] args)
        {

            int[] arr = { 100, 6, 7, 8, 9, 11, 100 }; 

            Array.Sort(arr);

            int target = 113;

            for (int i = 1; i < arr.Length - 2; i++)
            {
                int left = i - 1 ;
                int right = arr.Length - 1;

                for (int j = left; j < right; j++)
                {
                    int sum = arr[i] + arr[left] + arr[right];

                    if (sum == target)
                    {
                        Console.WriteLine($" {arr[i]} + {arr[left]} + {arr[right]}");
                        return;
                    }
                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            Console.WriteLine("Числа отсутствуют");
        }
    }
}
