using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public static class UserInterface
    {
        /*
         * create a user interface for any information the application would need to get from the user. 
         * One example would be the functionality to assign a Contestant object:
         *      first name, 
         *      last name, 
         *      email address, 
         *      registration number.
         * 
         */

        public static string GetUserInputFor(string prompt)
        {
            switch (prompt.ToLower())
            {
                case "first":
                    Console.WriteLine("Please enter your first name:");
                    return Console.ReadLine();
                case "last":
                    Console.WriteLine("Please enter your last name:");
                    return Console.ReadLine();
                case "email":
                    Console.WriteLine("Please enter your e-mail address:");
                    return Console.ReadLine();
                default:
                    return "Please choose a valid option";                    
            }            
        }
        public static void DisplayContestantInfo(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            Console.WriteLine("Contestant Information\n====================================");
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("E-mail Address: {0}", emailAddress);
            Console.WriteLine("Registration Number: {0}\n", registrationNumber);
        }
        public static string GetSweepstakesName()
        {
            Console.WriteLine("Please choose a name for your Sweepstakes:");
            return Console.ReadLine();
        }
        public static string GetManagerType()
        {
            Console.WriteLine("Choose the type of Sweepstakes you would like to manage:");
            return Console.ReadLine();
        }
        public static void NotifyWinner(string firstName, string lastName)
        {
            Console.WriteLine("Congratulations, {0} {1}! You've won the sweepstakes!", firstName, lastName);
        }
    }
}
