using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreateBuilder : IBuilder
    {
        private Product product;
        public ConcreateBuilder()
        {
            this.product = new Product();
        }
        public void BuildPartA()
        {
            this.product.PartA = "PartA Added";
        }

        public void BuildPartB()
        {
            this.product.PartB = "PartB Added";
        }

        public void BuildPartC()
        {
            this.product.PartC = "PartC Added";
        }

        public Product GetProduct()
        {
            return this.product;
        }
    }
}
