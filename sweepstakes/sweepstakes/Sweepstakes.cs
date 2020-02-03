using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name { get; }

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
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
            UserInterface.DisplayContestantInfo(contestant.FirstName, contestant.LastName, contestant.EmailAddress, contestant.RegistrationNumber);
        }
        public void NotifyContestants(IContestant contestant)
        {
            Contestant winner = PickWinner();
            foreach (KeyValuePair<int, Contestant> key in contestants)
            {
                if (winner.EmailAddress == key.Value.EmailAddress)
                {
                    UserInterface.NotifyWinner(winner.FirstName, winner.LastName);
                }
                else
                {
                    contestant.Notify(contestant);
                }                
            }
        }        
    }
}
