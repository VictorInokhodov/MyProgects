using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL.Interfaces
{
    public interface IUsersDAO
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        IEnumerable<User> GetUsers();
    }
}
