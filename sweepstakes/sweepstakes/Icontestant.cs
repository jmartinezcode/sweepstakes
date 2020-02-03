using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public interface IContestant
    {
        string FirstName { get; }
               
        void Notify(IContestant contestant);
    }
}
