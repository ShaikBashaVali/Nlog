namespace LoggerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNumbers obj = new AddNumbers();
            obj.Sum(2, 0);
            Console.WriteLine("This is a Logger Demo and Logs generated Successfully");
            Console.ReadKey();
        }
    }
}