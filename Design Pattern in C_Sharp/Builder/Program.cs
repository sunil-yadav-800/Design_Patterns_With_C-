using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ConcreateBuilder concreateBuilder = new ConcreateBuilder();
            director.Construct(concreateBuilder);
            Product product = concreateBuilder.GetProduct();
            product.Display();
        }
    }
}
