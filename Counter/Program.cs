namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Increment();
            counter.Increment();
            counter.Increment();
            // ska skriva ut 3
            Console.WriteLine("counter: " + counter.GetValue());
            counter.Reset();
            // ska skriva ut 0
            Console.WriteLine("counter: " + counter.GetValue());
        }


    }
}