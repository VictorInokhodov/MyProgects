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
        private string connectionString;
        public DAL.Interfaces.IRewardsDAO Rewards;

        public RewardsBL(ServiseOptions options)
        {
            if (options.Context == "adonet")
            {
                Rewards = new RewardsDAODataService(options.ConnectionString);
            }
            else
            {
                Rewards = new RewardsDAO();
            }
        }

        public void AddReward(Reward reward)
        {
            Rewards.AddReward(reward);
        }

        public void DeleteReward(int id)
        {
            Rewards.DeleteReward(id);
        }

        public IEnumerable<Reward> GetRewards()
        {
            return Rewards.GetRewards();
        }

        public void UpdateReward(Reward reward)
        {
            Rewards.UpdateReward(reward);
        }
    }
}
