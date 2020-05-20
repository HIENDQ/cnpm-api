using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timtro.Models;

namespace timtro.Services
{
    public class UserService : IUserService
    {
        private DataContext _context;
        public UserService (DataContext context)
        {
            _context=context;
        }

        public List<User> GetUsers()
         {
             return _context.Users.ToList();
         }


        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x=> x.UserId==id);
        }

        public bool AddUser(User user)
        {
            try
           {
            _context.Add(user);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeleteUser(int id)
        {
            try
            {
                _context.Users.Remove(GetUserById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool UpdateUser(User user)
        {
            try
            {
            var user1 = _context.Users.FirstOrDefault(x=> x.UserId == user.UserId);
            user1.UserName= user.UserName;
            user1.Password= user.Password;
            user1.Name=user.Name;
            user1.Birthday=user.Birthday;
            user1.Gender=user.Gender;
            user1.Phone=user.Phone;
            user1.Address=user.Address;
            user1.Email=user.Email;
            _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
    
}