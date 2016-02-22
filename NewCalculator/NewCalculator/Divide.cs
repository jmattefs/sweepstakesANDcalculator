using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    class Divide: Operator
    {
        int X;
        int Y;
        public Divide(int x, int y):base(x, y)
        {
            this.X = x;
            this.Y = y;
        }

        public double answer(int x, int y)
        {

            double answer = x / y;
            return answer;
        }
        public override double Division(int x, int y)
        {
            double answer = (double)x / y;
            return answer;
        }

    }
}
