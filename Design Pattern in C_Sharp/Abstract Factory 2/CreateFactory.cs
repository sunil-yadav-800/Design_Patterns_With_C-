using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class CreateFactory
    {
        private readonly string type;
        public IFurnitureFactory furnitureFactory;
        public CreateFactory(string type)
        {
            this.type = type;
            create();
        }
        public void create()
        {
            if (type == "modern")
            {
                furnitureFactory = new ModernFactory();
            }
            else if (type == "victorian")
            {
                furnitureFactory = new VictorianFactory();
            }
            else
            {
                furnitureFactory = null;
            }
        }
    }
}
