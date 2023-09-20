using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class MacCheckbox : ICheckbox
    {
        public void create()
        {
            Console.WriteLine("Mac checkbox created..");
        }
    }
}
