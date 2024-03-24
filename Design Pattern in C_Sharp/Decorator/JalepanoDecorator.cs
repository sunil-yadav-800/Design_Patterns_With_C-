using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class JalepanoDecorator : PizzaDecorator
    {
        public JalepanoDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string bake()
        {
            return pizza.bake() +" "+ addJalepano();
        }
        private string addJalepano()
        {
            return "jalepano";
        }
    }
}
