using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if(!isAllowable(value, b, c))
                {
                    throw new Exception("This triangle can't be allowable.");
                }

                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (!isAllowable(a, value, c))
                {
                    throw new Exception("This triangle can't be allowable.");
                }

                b = value;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (!isAllowable(a, b, value))
                {
                    throw new Exception("This triangle cante be allowable.");
                }

                c = value;
            }
        }

        public Triangle(int aSide, int bSide, int cSide)
        {
            Set(aSide, bSide, cSide);
        }

        public void Set(int aSide, int bSide, int cSide)
        {
            if (!isAllowable(aSide, bSide, cSide))
            {
                throw new Exception("This triamgle cante be allowable.");
            }

            a = aSide;
            b = bSide;
            c = cSide;
        }

        public double Area()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public int Perimeter()
        {
            return a + b + c;
        }

        private bool isAllowable(int A, int B, int C)
        {
            return !(A + B <= C ||
                A + C <= B ||
                B + C <= A);
        }
    }
}
