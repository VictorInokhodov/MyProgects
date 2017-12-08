using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public delegate void DeleteHandler(Reward reward);

    public class RewardsDAO : Interfaces.IRewardsDAO
    {
        private static int ID = 1;

        public static event DeleteHandler OnDelete;
        public static event DeleteHandler OnUpdate;

        private List<Reward> Rewards = new List<Reward>();

        public void AddReward(Reward reward)
        {
            Rewards.Add(reward);
            Rewards[Rewards.Count - 1].ID = ID;
            ID++;
        }

        public void DeleteReward(int id)
        {
            for (int i = 0; i < Rewards.Count; i++)
            {
                if (Rewards[i].ID == id)
                {
                    OnDelete?.Invoke(Rewards[i]);

                    Rewards.Remove(Rewards[i]);

                    break;
                }
            }
        }

        public IEnumerable<Reward> GetRewards()
        {
            return Rewards;
        }

        public void UpdateReward(Reward reward)
        {
            foreach (Reward rew in Rewards)
            {
                if (rew.ID == reward.ID)
                {
                    rew.Title = reward.Title;
                    rew.Description = reward.Description;

                    OnUpdate?.Invoke(rew);
                }
            }
        }
    }
}
