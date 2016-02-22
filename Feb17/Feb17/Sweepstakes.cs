using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    class Sweepstakes
    {
        Dictionary<string, int> Dictionary = new Dictionary<string, int>();
        public Sweepstakes()
        {

        }
        public void RegisterContestant(Contestant contestant)
        {
            Dictionary.Add(contestant.ToString(), 0);
        }
        public string PickWinner(Contestant c)
        {
            return c.ToString();
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }

    }
}
