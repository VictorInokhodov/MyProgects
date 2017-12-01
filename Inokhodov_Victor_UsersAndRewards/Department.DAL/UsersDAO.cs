using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class UsersDAO : Interfaces.IUsersDAO
    {
        private static int ID = 1;

        private List<User> users = new List<User>();

        public UsersDAO()
        {
            RewardsDAO.OnDelete += Deleted;
        }

        public void Deleted(Reward reward)
        {
            foreach (User user in users)
            {
                for (int i = 0; i < user.Rewards.Count; i++)
                {
                    if (user.Rewards[i].Title == reward.Title)
                    {
                        user.Rewards.Remove(user.Rewards[i]);
                    }
                }
            }
        }

        public void AddUser(User user)
        {
            users.Add(user);
            users[users.Count - 1].ID = ID;
            ID++;
        }
        
        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public void UpdateRewards(Reward prevReward, Reward reward)
        {
            foreach (User user in users)
            {
                for (int i = 0; i < user.Rewards.Count; i++)
                {
                    if (user.Rewards[i].Title == prevReward.Title)
                    {
                        user.Rewards[i].Title = reward.Title;
                    }
                }
            }
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }
    }
}
