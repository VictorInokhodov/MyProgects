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
            RewardsDAO.OnUpdate += UpdateReward;
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

        public void UpdateReward(Reward reward)
        {
            foreach (User user in users)
            {
                for (int i = 0; i < user.Rewards.Count; i++)
                {
                    if (reward.ID == user.Rewards[i].ID)
                    {
                        user.Rewards[i].Title = reward.Title;
                        user.Rewards[i].Description = reward.Description;

                        break;
                    }
                }
            }
        }

        public void DeleteUser(int id)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == id)
                {
                    users.Remove(users[i]);

                    break;
                }
            }
        }

        public void UpdateUser(User user)
        {
            foreach (User us in users)
            {
                if (us.ID == user.ID)
                {
                    us.FName = user.FName;
                    us.LName = user.LName;
                    us.DateOfBirth = user.DateOfBirth;
                    us.Rewards = user.Rewards;
                }
            }
        }
    }
}
