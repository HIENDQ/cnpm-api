using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timtro.Models;

namespace timtro.Services
{
    public class LoginService : IUserLoginService
    {
        private DataContext _context;
        public LoginService (DataContext context)
        {
            _context=context;
        }

        public bool UserLogin(string username, string password)
        {
            try
            {
                var username1 = _context.Users.FirstOrDefault(x=> x.UserName == username);
                if (username == null) 
                {
                   return false;
                }
                else
                {
                    if (username1.Password == password)
                    {
                        return true;
                    }
                    else return false;
                }
             
             
            }
            catch (System.Exception)
            {
                return false;
            }
            
             
        }
    }
    
    
}