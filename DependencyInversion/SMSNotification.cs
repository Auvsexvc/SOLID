using System;

namespace DependencyInversion
{
    public class SMSNotification : INotificationSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending sms notification to {user.Name}");
        }
    }
}