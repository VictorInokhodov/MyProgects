using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL.Interfaces
{
    public interface IRewardsDAO
    {
        void AddReward(Reward reward);
        void UpdateReward(Reward reward);
        void DeleteReward(int id);
        IEnumerable<Reward> GetRewards();
    }
}
