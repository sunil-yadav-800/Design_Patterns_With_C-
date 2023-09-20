using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class BirdAdapter : IToyDuck
    {
        private IBird bird;
        public BirdAdapter(IBird bird)
        {
            this.bird = bird;
        }
        public void squeak()
        {
            bird.makeSound();
        }
    }
}
