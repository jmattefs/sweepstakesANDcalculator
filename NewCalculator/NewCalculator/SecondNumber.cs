using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    class SecondNumber : INotify
    {
        public int NumberTwo()
        {
            Console.WriteLine("What is the second number?");
            int convertedNumber;

            while (!Int32.TryParse(Console.ReadLine(), out convertedNumber))
            {
                Console.WriteLine("Try Again");
            }
            return convertedNumber;
        }
        public void Notify(int y)
        {
            Console.WriteLine("--->Input is " + y);
        }
    }
}
