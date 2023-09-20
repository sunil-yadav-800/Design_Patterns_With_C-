
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class DogCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
