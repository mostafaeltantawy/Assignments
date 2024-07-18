using AssignOOP04.Q2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP04.Q2
{
    public enum Role
    {
        Admin,
        User
    }



    internal class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, (string Password, Role role)> users = new Dictionary<string, (string, Role)>
    {
        { "Mostafa", ("123456",Role.User) },
        { "Eltantawy", ("2312",Role.Admin) }
    };
        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username) && users[username].Password == password) 
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username , Role role)
        {
            if (users.ContainsKey(username) && users[username].role == role) 
            {
                return true;
            }
            return false;
        }

    
    }
}
