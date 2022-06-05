namespace DependencyInversion
{
    public class AuthenticationManager
    {
        private INotificationSender emailNotification;

        public AuthenticationManager(INotificationSender emailNotification)
        {
            this.emailNotification = emailNotification;
        }

        public void Authenticate(User user, string email, string password)
        {
            if (user.Email == email && user.Password == password)
            {
                emailNotification.SendNotification(user);
            }
        }
    }
}