using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class SparrowBird : IBird
    {
        public void fly()
        {
            Console.WriteLine("flying..");
        }

        public void makeSound()
        {
            Console.WriteLine("Chirp Chirp...");
        }
    }
}
