using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP04.Q2.Interfaces
{
    internal interface IAuthenticationService
    {


        public bool AuthenticateUser(string username, string password);

        public bool AuthorizeUser(string username , Role role); 


    }
}
