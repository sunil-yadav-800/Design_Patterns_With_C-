using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Patern_2
{
    public class SmsNotification : INotification
    {
        public void notifyUser()
        {
            Console.WriteLine("sending an sms...");
        }
    }
}
