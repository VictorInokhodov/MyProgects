using Entities;
using Department.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class RewardsBL
    {
        public DAL.Interfaces.IRewardsDAO Rewards;

        public RewardsBL()
        {
            Rewards = new RewardsDAO();
        }

        public void AddReward(Reward reward)
        {
            Rewards.AddReward(reward);
        }

        public void DeleteReward(Reward reward)
        {
            Rewards.DeleteReward(reward);
        }

        public IEnumerable<Reward> GetRewards()
        {
            return Rewards.GetRewards();
        }
    }
}
