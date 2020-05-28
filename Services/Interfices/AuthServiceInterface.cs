using System.Collections.Generic;
using timtro.Models;

namespace timtro.Services
{
    public interface IAuthService
    {
        public bool UserLogin(string username,string password);
        public bool SignUp(AuthSignUp user);
        public bool ValidateBeforeSignUp(AuthSignUp user);
    }
}