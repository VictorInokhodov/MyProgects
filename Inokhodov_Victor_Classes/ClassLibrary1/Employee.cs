using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee : User
    {
        private string position;
        private int stage;

        public int Stage
        {
            get
            {
                return stage;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Stage can't be lower then 0.");
                }

                stage = 0;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Position can't be empty.");
                }

                position = value;
            }
        }

        public Employee(string name, string serName, DateTime dateOfBirth, int stage, string position, string patronymic = null) :
            base(name, serName, dateOfBirth, patronymic)
        {
            Stage = stage;
            Position = position;
        }
    }
}
