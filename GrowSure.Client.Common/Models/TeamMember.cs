using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowSure.Client.Common.Models
{
    public class TeamMember
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string UserName { get; private set; }
      
        public string Password { get; private set; }
        
        public string Avatar { get; private set; }

        public TeamMember(string firstName, string lastName, string userName, string password, string avatar)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Avatar = avatar;
        }
    }
}
