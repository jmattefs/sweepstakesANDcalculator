﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    class Subtract: Operator
    {
        int X;
        int Y;
        public Subtract(int x, int y):base(x,y)
        {
            this.X = x;
            this.Y = y;
        }

        public double answer(int x, int y)
        {
            int answer = x - y;
            return answer;
        }
        public override double Subtraction(int x, int y)
        {
            double answer = x - y;
            return answer;
        }

    }
}
