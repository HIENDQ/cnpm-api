using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using timtro.Models;

namespace timtro.Services
{
    public class AuthService : IAuthService
    {
        private DataContext _context;
        public AuthService (DataContext context)
        {
            _context=context;
        }

        public bool SignUp(AuthSignUp user)
        {   
            
            try
            {
                var newUser = new User
                {
                    UserName = user.UserName,
                    Password = user.Password,
                    Address = user.Address,
                    Birthday = user.Birthday,
                    Email = user.Email,
                    Name = user.Name,
                    Gender = user.Gender,
                    Phone = user.Phone,
                    DateCreate = DateTime.Now,
                    DateUpdate = DateTime.Now
                };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
         
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

        public bool ValidateBeforeSignUp(AuthSignUp user)
        {
            var totalEmail = _context.Users.Count(x => x.Email == user.Email);
            var totalUserName = _context.Users.Count(x=>x.UserName == user.UserName);
            if (totalEmail >= 1 || totalUserName >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}