﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PlasticToyDuck : IToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
