﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrivenDevelopmentOefenLibrary;

namespace TestDrivenDevelopmentOefenLibraryTest
{
    class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 1000.0m;
        }
    }
}
