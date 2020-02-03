using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            //Factory Manager created, use switch case
            ManagerFactory manager = new ManagerFactory();
            MarketingFirm firm = new MarketingFirm(manager.ChooseManagerType(UserInterface.GetManagerType()));

        }
    }
}
