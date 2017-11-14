using System;

namespace InterfacePolymorphism
{
    internal class SMSNotificationChannel: INotificationChannel
    { 

        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}