namespace Hero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Maurlock m1 = new Maurlock(100, 10, 80, 80, 90);
            Lion l1 = new Lion(100, 20, 90);

            m1.Run();
            m1.Attack();
            m1.Defend();
            m1.Display();

            l1.Run();
            l1.Attack();
            l1.Defend();
            l1.Display();

        }
    }
}