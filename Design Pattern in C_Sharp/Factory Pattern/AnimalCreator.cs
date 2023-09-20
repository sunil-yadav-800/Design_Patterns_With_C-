using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public abstract class AnimalCreator
    {
        public abstract IAnimal CreateAnimal();

        public void Interact()
        {
            // Use the factory method to create an animal
            IAnimal animal = CreateAnimal();

            // Interact with the animal
            animal.MakeSound();
        }
    }
}
