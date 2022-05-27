namespace DependencyInversion
{
    public class EmailNotification : INotificationSender
    {
        public void SendNotification(User user)
        {
            System.Console.WriteLine($"Sending notification to {user.Name}");
        }
    }
}