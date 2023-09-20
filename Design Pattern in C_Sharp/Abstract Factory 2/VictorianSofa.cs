using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    public class VictorianSofa : ISofa
    {
        public void buildSofa()
        {
            Console.WriteLine("Victorian sofa is built..");
        }
    }
}
