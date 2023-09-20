using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        public void BuildPartA();
        public void BuildPartB();
        public void BuildPartC();
        public Product GetProduct();
    }
}
