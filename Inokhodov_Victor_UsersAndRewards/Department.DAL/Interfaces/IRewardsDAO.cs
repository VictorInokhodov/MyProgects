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
        void DeleteReward(Reward reward);
        IEnumerable<Reward> GetRewards();
    }
}
