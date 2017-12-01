using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserDataGridView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Rewards { get; set; }

        public static UserDataGridView GetModel(User user)
        {
            return new UserDataGridView
            {
                Id = user.ID,
                FirstName = user.FName,
                LastName = user.LName,
                Birthdate = user.DateOfBirth,
                Age = user.Age,
                Rewards = string.Join(", ", user.Rewards?.Select(r => r.Title) ?? new List<string>())
            };
        }
    }
}
