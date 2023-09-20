using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IBird sparrow = new SparrowBird();
            IToyDuck toyDuck = new PlasticToyDuck();

            IToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.fly();
            sparrow.makeSound();

            Console.WriteLine("ToyDuck...");
            toyDuck.squeak();

            Console.WriteLine("BirdAdapter...");
            birdAdapter.squeak();
        }
    }
}
