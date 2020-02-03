using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Contestant: IContestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        int registrationNumber;

        public string FirstName { get; }
        public string LastName { get; }
        public string EmailAddress { get; }
        public int RegistrationNumber { get; }
        public Contestant(int registrationNumber)
        {
            firstName = UserInterface.GetUserInputFor("first"); 
            lastName = UserInterface.GetUserInputFor("last");
            emailAddress = UserInterface.GetUserInputFor("email"); 
            this.registrationNumber = registrationNumber;
        }
        public void Notify(IContestant contestant)
        {
            Console.WriteLine("The winner has been drawn, better luck next time, {0}!", contestant.FirstName);
        }

    }
}
