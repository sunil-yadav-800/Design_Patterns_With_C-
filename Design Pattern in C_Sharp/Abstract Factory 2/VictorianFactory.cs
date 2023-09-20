using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    public class VictorianFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ISofa createSofa()
        {
            return new VictorianSofa();
        }
    }
}
