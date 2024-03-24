using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheeseBrustDecorator : PizzaDecorator
    {
        public CheeseBrustDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string bake()
        {
            return pizza.bake() + " "+ addCheeseBrust();
        }
        private string addCheeseBrust()
        {
            return "CheeseBrust";
        }
    }
}
