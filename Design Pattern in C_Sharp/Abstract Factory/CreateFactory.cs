using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class CreateFactory
    {
        private readonly string type;
        public CreateFactory(string type)
        {
            this.type = type;
        }
        public IPlatformFactory create()
        {
            if(type == "window")
            {
                return new WindowFactory();
            }
            else if(type == "mac")
            {
                return new MacFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
