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

        public UsersBL()
        {
            Users = new UsersDAO();
        }

        public void AddUser(User user)
        {
            Users.AddUser(user);
        }

        public IEnumerable<User> GetUser()
        {
            return Users.GetUsers();
        }

        public void DeleteUser(User user)
        {
            Users.DeleteUser(user);
        }

        public void UpdateRewards(Reward prevReward, Reward reward)
        {
            Users.UpdateRewards(prevReward, reward);
        }
    }
}
