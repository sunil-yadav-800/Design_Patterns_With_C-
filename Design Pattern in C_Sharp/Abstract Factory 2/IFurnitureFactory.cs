using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    public interface IFurnitureFactory
    {
        public IChair createChair();
        public ISofa createSofa();
    }
}
