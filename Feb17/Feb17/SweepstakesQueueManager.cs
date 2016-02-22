using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb17
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<string> NewQueue = new Queue<string>();
        public Sweepstakes GetNextSweepstakesWinner()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
