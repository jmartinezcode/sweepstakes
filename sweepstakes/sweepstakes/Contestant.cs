using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Contestant
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
            firstName = UserInterface.GetUserInputFor("input"); //be more specific once UI created
            lastName = UserInterface.GetUserInputFor("input");//be more specific once UI created
            emailAddress = UserInterface.GetUserInputFor("input"); //be more specific once UI created
            this.registrationNumber = registrationNumber;
        }
    }
}
