using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentOefenLibrary
{
    public class Veiling
    {
        private decimal hoogsteBod;
        public void DoeBod(decimal bedrag)
        {
            if (bedrag < 0)
            throw new ArgumentException();
            if (bedrag > hoogsteBod)
                hoogsteBod = bedrag;
        }

        public decimal HoogsteBod()
        {
            return hoogsteBod;
        }
    }
}
