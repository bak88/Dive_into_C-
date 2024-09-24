namespace dz6._2
{
    internal class Program
    {
        //Дан массив и число.Найдите три числа в массиве сумма которых равна искомому числу.
        //Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому

        static void Main(string[] args)
        {
            int[] array = new int[] { -2, 10, 2, 6, 4, -1, 12, 13, -15, 9 };
            int target = 10;

            FindSumFrom3Elements(array, target);
        }

        static void FindSumFrom3Elements(int[] array, int targetSum)
        {
            bool hasTarget = false;

            for (int i = 0; i < array.Length - 2; i++)
            {
                HashSet<int> set = new HashSet<int>();
                int currentSum = targetSum - array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (set.Contains(currentSum - array[j]))
                    {
                        Console.WriteLine($"Число {targetSum} получается суммой элементов {array[i]}, {array[j]}, {currentSum - array[j]} массива");
                        hasTarget = true;
                    }
                    set.Add(array[j]);
                }
            }
            if (!hasTarget) { Console.WriteLine($"В массиве нет трёх элементов, сумма которых = {targetSum}"); }
        }
    }
}
