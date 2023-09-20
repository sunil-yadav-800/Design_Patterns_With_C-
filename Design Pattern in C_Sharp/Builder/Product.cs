using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }
        public void Display()
        {
            Console.WriteLine("Product Details: ");
            if(PartA != null)
            Console.WriteLine("PartA: " + PartA);
            if(PartB != null)
            Console.WriteLine("PartB: " + PartB);
            if(PartC != null)
            Console.WriteLine("PartC: " + PartC);
        }
    }
}
