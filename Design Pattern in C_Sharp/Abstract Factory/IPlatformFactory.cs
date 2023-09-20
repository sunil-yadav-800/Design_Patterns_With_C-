using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IPlatformFactory
    {
        public IButton createButton();
        public ICheckbox createCheckBox();
    }
}
