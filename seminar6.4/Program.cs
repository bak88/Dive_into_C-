namespace seminar6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();

            strList.Add("Jack");
            strList.Add("Jin");
            strList.Add("Jon");
            strList.Add("Lassi");
            strList.Add("Den");

            

            var res = strList.Where(s => s.ToUpper().Contains("j".ToUpper())).Select(x => x.ToUpper());
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
