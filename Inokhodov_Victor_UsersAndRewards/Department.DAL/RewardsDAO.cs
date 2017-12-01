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

        private List<Reward> Rewards = new List<Reward>();

        public void AddReward(Reward reward)
        {
            Rewards.Add(reward);
            Rewards[Rewards.Count - 1].ID = ID;
            ID++;
        }

        public void DeleteReward(Reward reward)
        {
            Rewards.Remove(reward);

            OnDelete?.Invoke(reward);
        }

        public IEnumerable<Reward> GetRewards()
        {
            return Rewards;
        }
    }
}
