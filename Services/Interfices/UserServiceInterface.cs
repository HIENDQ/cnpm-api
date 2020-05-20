using System.Collections.Generic;
using timtro.Models;

namespace timtro.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUserById(int id);

        public bool AddUser(User user);

        public bool UpdateUser(User user);

        public bool DeleteUser(int id);
    }
}