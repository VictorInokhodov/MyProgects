using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ring : Round
    {
        private int insideRadius;

        public int InsideRadius
        {
            get
            {
                return insideRadius;
            }
            set
            {
                if (value < 0 || value >= radius)
                {
                    throw new Exception("This inside radius can't be allowable.");
                }

                insideRadius = value;
            }
        }

        public Ring(int x, int y, int radius, int insideRadius) : base(x, y, radius)
        {
            InsideRadius = insideRadius;
        }
        
        public override double Area()
        {
            return base.Area() - InsideArea();
        }

        private double InsideArea()
        {
            return Math.PI * insideRadius * insideRadius;
        }

        public override double Length()
        {
            return base.Length() + InsideLength();
        }

        private double InsideLength()
        {
            return 2 * Math.PI * insideRadius;
        }
    }
}
