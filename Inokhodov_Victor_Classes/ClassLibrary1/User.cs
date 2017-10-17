using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        protected string name;
        protected string serName;
        protected DateTime dateOfBirth;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty.");
                }
                name = value;
            }
        }
        public string SerName
        {
            get
            {
                return serName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Sername can't be empty.");
                }
                serName = value;
            }
        }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if(value == null && value.Date < DateTime.Now.Date)
                {
                    throw new Exception("Date isn't avalible.");
                }

                dateOfBirth = value;
            }
        }
        public int Age
        {
            get
            {
                return new DateTime((DateTime.Now.Date - dateOfBirth.Date).Ticks).Year;
            }
        }

        public User(string name, string serName, DateTime dateOfBirth, string patronymic = null)
        {
            Name = name;
            SerName = serName;
            DateOfBirth = dateOfBirth;
            Patronymic = patronymic;
        }
    }
}
