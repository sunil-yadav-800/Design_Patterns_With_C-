using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalCreator dogCreator = new DogCreator();
            dogCreator.Interact(); // Output: "Woof!"

            // Create a CatCreator
            AnimalCreator catCreator = new CatCreator();
            catCreator.Interact(); // Output: "Meow!"
        }
    }
}
