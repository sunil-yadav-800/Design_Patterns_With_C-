using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new CheeseBrustDecorator(new JalepanoDecorator(new BasePizza()));

            Console.WriteLine(pizza.bake());
        }
    }
}
