using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name { get; }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            // pick a random winner, return contestant object
            Random random = new Random();
            int key = random.Next(contestants.Count);
            Contestant contestant = contestants[key];
            return contestant;
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        
    }
}
