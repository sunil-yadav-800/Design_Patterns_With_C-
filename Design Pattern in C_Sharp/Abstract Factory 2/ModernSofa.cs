using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    public class ModernSofa : ISofa
    {
        public void buildSofa()
        {
            Console.WriteLine("Modern sofa is built..");
        }
    }
}
