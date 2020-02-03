using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class ManagerFactory
    {

        public ISweepstakesManager ChooseManagerType(string input)
        {
            switch (input.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return ChooseManagerType(input);
            }
        }
    }
}
