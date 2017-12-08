using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.DAL.Interfaces;

namespace Department.DAL
{
    public class UsersDAODataSservice : Interfaces.IUsersDAO
    {
        private readonly string connectionString;

        public UsersDAODataSservice(string connection)
        {
            connectionString = connection;
        }

        public void AddUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "InsertUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@firstName", user.FName);
                command.Parameters.AddWithValue("@lastName", user.LName);
                command.Parameters.AddWithValue("@birthdate", user.DateOfBirth);

                connection.Open();

                user.ID = (int)command.ExecuteScalar();

                AddUserRewards(connection, user);

                connection.Close();
            }
        }

        private void AddUserRewards(SqlConnection connection, User user)
        {
            DataTable tempRewardsTable = new DataTable();
            tempRewardsTable.Columns.Add("RewardId", typeof(int));
            foreach (var r in user.Rewards)
            {
                tempRewardsTable.Rows.Add(r.ID);
            }

            using (var command = new SqlCommand())
            {
                command.CommandText = "InsertUserRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("@userId", user.ID);
                var rewardsTablePArameter = command.Parameters.AddWithValue("@rewardIds", tempRewardsTable);
                rewardsTablePArameter.SqlDbType = SqlDbType.Structured;

                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@userId", id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public IEnumerable<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetUsers";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new User();
                        user.ID = reader.GetInt32(0);
                        user.FName = reader.GetString(1);
                        user.LName = reader.GetString(2);
                        user.DateOfBirth = reader.GetDateTime(3);
                        users.Add(user);
                    }
                }

                connection.Close();
            }
            FillUserRewards(users);
            return users;
        }

        public void UpdateUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdateUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", user.ID);
                command.Parameters.AddWithValue("@fname", user.FName);
                command.Parameters.AddWithValue("@lname", user.LName);
                command.Parameters.AddWithValue("@birthdate", user.DateOfBirth);

                connection.Open();

                command.ExecuteNonQuery();

                DeleteUserRewards(connection, user.ID);

                AddUserRewards(connection, user);

                connection.Close();
            }
        }

        private void DeleteUserRewards(SqlConnection connection, int id)
        {
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteUserRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }

        private void FillUserRewards(List<User> users)
        {
            foreach (var user in users)
            {
                user.Rewards = new List<Reward>();
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    command.CommandText = "GetUserRewards";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@userId", user.ID);

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
                            user.Rewards.Add(reward);
                        }
                    }

                    connection.Close();
                }
            }
        }
    }
}
