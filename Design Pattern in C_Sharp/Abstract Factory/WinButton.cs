using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class WinButton : IButton
    {
        public void create()
        {
            Console.WriteLine("Window button created..");
        }
    }
}
