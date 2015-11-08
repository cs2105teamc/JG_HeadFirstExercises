using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex3
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceivedContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + returnedContents.Sparkles());
        }
    }
}
