using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for dog, 2 for cat or 3 for cow");

            var choice = Console.ReadLine();
            var animal = AnimalFactory.Build(Convert.ToInt32(choice));
            Console.WriteLine($" You chose a {animal.GetType().Name}: {animal.MakeSound()}");
            Console.Read();
        }
    }
}
