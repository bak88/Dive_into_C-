namespace seminar7._2
{
    internal class Program
    {
        private static void ClassWithEvents_SomeEventHandler(object sender, MyEventArgs args)
        {
            Console.WriteLine($" Send {sender}, with message {args.Message}");
        }
        static void Main(string[] args)
        {
            var classWithEvents = new ClassWithEvents();

            classWithEvents.SomeEvent += ClassWithEvents_SomeEventHandler;

            classWithEvents.DoSomeWork();

            Console.WriteLine("Ждем события ");
        }
    }
}
