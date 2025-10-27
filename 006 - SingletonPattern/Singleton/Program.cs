namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ChocolateBoiler boiler = ChocolateBoiler.GetInstance;
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance;

            if (boiler == boiler2)
            {
                Console.WriteLine("Both are the same instance");
            }
            else
            {
                Console.WriteLine("Different instances");
            }

            boiler.fill();
            boiler.boil();
            boiler.drain();

            Console.WriteLine("Boiler is empty: " + boiler.IsEmpty);
            Console.WriteLine("Boiler is boiled: " + boiler.IsBoiled);
        }
    }
}