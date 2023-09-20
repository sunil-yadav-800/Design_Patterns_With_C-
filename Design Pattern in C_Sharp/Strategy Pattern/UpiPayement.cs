using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class UpiPayement : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"paying ${amount} with upi");
        }
    }
}
