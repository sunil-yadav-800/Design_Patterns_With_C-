using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Patern_2
{
    public class NotificationFactory
    {
        public INotification CreateNotification(string notificationType)
        {
            if (notificationType == "email")
                return new EmailNotification();
            else if (notificationType == "sms")
                return new SmsNotification();
            else
                return null;
        }
    }
}
