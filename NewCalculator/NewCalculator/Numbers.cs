using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    public class Numbers
    {
        FirstNumber fn = new FirstNumber();
        SecondNumber sn = new SecondNumber();


        public int One()
        {
            int x = fn.NumberOne();
            fn.Notify(x);
            return x;
        }
        public int Two()
        {
            int y = sn.NumberTwo();
            sn.Notify(y);
            return y;
        }
    }
}
