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
        void DeleteUser(User user);
        void UpdateRewards(Reward prevReward, Reward reward);
        IEnumerable<User> GetUsers();
    }
}
