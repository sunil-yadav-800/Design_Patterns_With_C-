using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;
        Dictionary<string, double> cart = new Dictionary<string, double>();
        public ShoppingCart()
        {
        }
        public void SetPaymenetStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
        public void AddItems(string itemName, double price)
        {
            cart.Add(itemName, price);
        }
        public void RemoveItems(string itemName)
        {
            cart.Remove(itemName);
        }
        public void ClearCart()
        {
            cart.Clear();
        }
        public void CheckOut()
        {
            if (paymentStrategy == null)
            {
                Console.WriteLine("please set paymenet strategy first");
            }
            else
            {
                double totalPrice = cart.Values.Sum();
                paymentStrategy.Pay(totalPrice);
            }
        }
    }
}
