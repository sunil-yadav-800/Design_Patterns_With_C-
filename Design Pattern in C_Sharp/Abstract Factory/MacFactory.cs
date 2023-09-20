using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class MacFactory : IPlatformFactory
    {
        public IButton createButton()
        {
            return new MacButton();
        }

        public ICheckbox createCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
