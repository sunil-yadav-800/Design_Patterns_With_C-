﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;
        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public virtual string bake()
        {
            return pizza.bake();
        }
    }
}
