using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentOefenLibrary
{
    public class ISBN
    {
        private long iSBNNummer;
        public ISBN(long nummer)
        {
            //controleren op negativiteit
            if (nummer < 0)
            throw new ArgumentException();
            //we maken van de long een string om daar handelingen op uit te kunnen voeren
            string nummerString = nummer.ToString();
            //controleren of de string 13 tekens bevat
            if (nummerString.Length != 13)
                throw new ArgumentException();
            //ints declareren om de tekens uit nummerString op te tellen, om het controlecijfer te bepalen
            int even = 0, oneven = 0;
            for (int x = 0; x < 12; ++x)
            {
                if (x % 2 == 0)
                    oneven += int.Parse(nummerString[x].ToString());
                else
                    even += int.Parse(nummerString[x].ToString());
            }
            int som = oneven + 3 * even;
            //controlecijfer bepalen
            int controleCijfer = 0;
            for (int x = 1; x <= 10; ++x)
            {
                if ((som + x) % 10 == 0)
                {
                    controleCijfer = (x == 10 ? 0 : x);
                    break;
                }
            }
            if (controleCijfer.ToString() == nummerString[12].ToString())
                this.iSBNNummer = nummer;
            else
                throw new ArgumentException();
        }
        public override string ToString()
        {
            return iSBNNummer.ToString();
        }
    }
}
