using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentOefenLibrary
{
    public class Woord
    {
        private string woord;
        public Woord(string woord)
        {
            if (woord == string.Empty)
            throw new ArgumentException();
            this.woord = woord;
        }

        public bool IsPalindroom()
        {
            for (int x = 0, y = woord.Length - 1; x <= y; ++x, --y)
            {
                if (woord[x] != woord[y])
                    return false;
            }
            return true;
        }
    }
}
