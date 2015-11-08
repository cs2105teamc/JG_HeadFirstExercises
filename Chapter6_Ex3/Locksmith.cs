using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex3
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;
        internal void WriteDownCombination(string safeCombination)
        {
            writtenDownCombination = safeCombination;
        }

        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceivedContents(safeContents);
        }
    }
}
