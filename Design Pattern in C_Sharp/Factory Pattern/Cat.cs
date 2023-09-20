﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
