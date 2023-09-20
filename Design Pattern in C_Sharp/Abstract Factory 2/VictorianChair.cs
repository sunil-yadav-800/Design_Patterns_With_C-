using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    public class VictorianChair : IChair
    {
        public void buildChair()
        {
            Console.WriteLine("Victorian chair is built..");
        }
    }
}
