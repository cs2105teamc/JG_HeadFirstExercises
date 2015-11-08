using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex3
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the jewels!" + stolenJewels.Sparkles());
        }
    }
}
