using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    public abstract class Operator
    {
        int X;
        int Y;
        public Operator(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual double Addition(int x, int y)
        {
            double answer = x + y;
            return answer;
        }
        public virtual double Subtraction(int x, int y)
        {
            double answer = x - y;
            return answer;
        }
        public virtual double Multiplication(int x, int y)
        {
            double answer = x * y;
            return answer;
        }
        public virtual double Division(int x, int y)
        {
            double answer = (double)x / y;
            return answer;
        }
    }
}
