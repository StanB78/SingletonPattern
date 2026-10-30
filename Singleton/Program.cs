namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instances = new ChocolateBoiler[100];
            Parallel.For(0, 100, i => instances[i] = ChocolateBoiler.GetInstance());
            Console.WriteLine(instances.Distinct().Count());

            //thread safe test
            var a = ChocolateBoiler.GetInstance();
            var b = ChocolateBoiler.GetInstance();

            Console.WriteLine(ReferenceEquals(a, b)); // True = dezelfde ketel

            Console.ReadKey();
        }
    }
}