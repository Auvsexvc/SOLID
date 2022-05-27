using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(user.Email==email && user.Password == password)
            {
                emailNotification.SendNotification(user);
            }
        }
    }
}
