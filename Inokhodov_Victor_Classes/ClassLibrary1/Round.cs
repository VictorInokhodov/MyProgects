using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Round
    {
        public int X { get; set; }
        public int Y { get; set; }
        protected int radius;

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Radius can't be lower or equal to zero.");
                }
                radius = value;
            }
        }

        public Round(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public virtual double Length()
        {
            return 2 * Math.PI * radius;
        }

        public virtual double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
