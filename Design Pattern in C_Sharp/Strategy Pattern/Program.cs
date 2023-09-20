using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItems("item 1", 90);
            cart.AddItems("item 2", 56.78);
            cart.AddItems("item 3", 46.23);
            cart.SetPaymenetStrategy(new DebitCardPayment());
            cart.CheckOut();
            cart.SetPaymenetStrategy(new UpiPayement());
            cart.RemoveItems("item 3");
            cart.CheckOut();
        }
    }
}
