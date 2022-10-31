using Autorization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization.Core
{
    class UserLogic
    {
        public static User FindUserByFirstName(List<User> users, string FirstName) => 
            users.FirstOrDefault(user => user.FirstName == FirstName);

        public static bool Validate(string login, string password) =>
            login == "Arina" && password == "3754";
    }
}
