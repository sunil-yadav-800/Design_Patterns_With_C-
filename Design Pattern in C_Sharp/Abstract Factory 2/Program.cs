using System;

namespace Abstract_Factory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFactory factory = new CreateFactory("modern");
            IFurnitureFactory modernFactory =  factory.furnitureFactory;
            IChair modernChair = modernFactory.createChair();
            ISofa modernSofa = modernFactory.createSofa();
            modernChair.buildChair();
            modernSofa.buildSofa();

            Console.WriteLine("..................");

            CreateFactory factory2 = new CreateFactory("victorian");
            IFurnitureFactory victorianFactory = factory2.furnitureFactory;
            IChair victorianChair = victorianFactory.createChair();
            ISofa victorianSofa = victorianFactory.createSofa();
            victorianChair.buildChair();
            victorianSofa.buildSofa();
        }
    }
}
