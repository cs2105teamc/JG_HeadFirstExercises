using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            Locksmith calledAsLockSmith = new Locksmith();
            calledAsLockSmith.OpenSafe(safe, owner);

            JewelThief calledAsJewelThief = new JewelThief();
            calledAsJewelThief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
