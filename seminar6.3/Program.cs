namespace seminar6._3
{
    internal class Program
    {
        //Поиск наиболее часто встречающихся элементов:
        //В списке объектов определенного типа найдите элементы, 
        //которые встречаются наибольшее количество раз

        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User() { FirstName = "Петр", LastName = "Петров", Age =  33});
            users.Add(new User() { FirstName = "Петр", LastName = "Сидоров", Age =  34});
            users.Add(new User() { FirstName = "Иван", LastName = "Петров", Age =  45});
            users.Add(new User() { FirstName = "Петр", LastName = "Иванов", Age =  30});
            users.Add(new User() { FirstName = "Иван", LastName = "Николаев", Age =  32});
            users.Add(new User() { FirstName = "Анна", LastName = "Николаев", Age =  23});
            users.Add(new User() { FirstName = "Жанна", LastName = "Андреевна", Age =  30});

            var sortFirsName = users.GroupBy(x => x.FirstName).OrderByDescending(x => x.Count()).First().Key;
            Console.WriteLine(sortFirsName);

            var sortAge = users.GroupBy(x => x.Age).OrderByDescending(x => x.Count()).First().Key;
            Console.WriteLine(sortAge);

            var sortLastName = users.GroupBy( x => x.LastName).OrderBy(x=> x.Count()).Last().Key;
            Console.WriteLine(sortLastName);


        }
    }
}
