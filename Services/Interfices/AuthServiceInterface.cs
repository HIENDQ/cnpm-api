using System.Collections.Generic;
using timtro.Models;

namespace timtro.Services
{
    public interface IUserLoginService
    {
        public bool UserLogin(string username,string password);

    }
}