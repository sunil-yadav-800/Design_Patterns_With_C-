using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class WindowFactory : IPlatformFactory
    {
        public IButton createButton()
        {
            return new WinButton();
        }

        public ICheckbox createCheckBox()
        {
            return new WinCheckBox();
        }
    }
}
