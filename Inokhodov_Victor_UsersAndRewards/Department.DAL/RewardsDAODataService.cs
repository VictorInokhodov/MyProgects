using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace Department.DAL
{
    public class RewardsDAODataService : Interfaces.IRewardsDAO
    {
        private readonly string connectionString;

        public RewardsDAODataService(string connection)
        {
            connectionString = connection;
        }

        public void AddReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "InsertReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@name", reward.Title);
                command.Parameters.AddWithValue("@description", reward.Description);



                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void DeleteReward(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@rewardId", id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public IEnumerable<Reward> GetRewards()
        {
           var rewards = new List<Reward>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reward = new Reward();
                        reward.ID = reader.GetInt32(0);
                        reward.Title = reader.GetString(1);
                        reward.Description = reader.GetString(2);

                        rewards.Add(reward);
                    }
                }

                connection.Close();
            }
            return rewards;
        }

        public void UpdateReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdateReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", reward.ID);
                command.Parameters.AddWithValue("@name", reward.Title);
                command.Parameters.AddWithValue("@description", reward.Description);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
