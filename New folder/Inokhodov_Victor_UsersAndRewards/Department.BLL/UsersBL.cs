using Entities;
using Department.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class UsersBL
    {
        public DAL.Interfaces.IUsersDAO Users;

        public UsersBL(ServiseOptions options)
        {
            if (options.Context == "adonet")
            {
                Users = new UsersDAODataSservice(options.ConnectionString);
            }
            else
            {
                Users = new UsersDAO();
            }
        }

        public void AddUser(User user)
        {
            Users.AddUser(user);
        }

        public IEnumerable<User> GetUser()
        {
            return Users.GetUsers();
        }

        public void DeleteUser(int id)
        {
            Users.DeleteUser(id);
        }

        public void UpdateUser(User user)
        {
            Users.UpdateUser(user);
        }
    }
}
