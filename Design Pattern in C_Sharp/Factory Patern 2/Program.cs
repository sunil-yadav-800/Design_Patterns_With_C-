using System;

namespace Factory_Patern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory notificationFactory = new NotificationFactory();
            INotification emailNotification = notificationFactory.CreateNotification("email");
            if(emailNotification != null)
                emailNotification.notifyUser();

            INotification smsNotification = notificationFactory.CreateNotification("sms");
            if (smsNotification != null)
                smsNotification.notifyUser();
        }
    }
}
