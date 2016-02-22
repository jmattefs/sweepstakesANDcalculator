using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    class FirstNumber : INotify
    {
        public int NumberOne()
        {
            Console.WriteLine("What is the first number?");
            int convertedNumber;

            while (!Int32.TryParse(Console.ReadLine(), out convertedNumber))
            {
                Console.WriteLine("Try Again");
            }
            return convertedNumber;
        }
        public void Notify(int x)
        {
            Console.WriteLine("--->Input is " +x);
        }
    }
}
