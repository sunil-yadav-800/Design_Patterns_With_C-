using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    public class ModernFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();
        }
    }
}
