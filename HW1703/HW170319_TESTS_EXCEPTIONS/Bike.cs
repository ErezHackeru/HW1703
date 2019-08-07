using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170319_TESTS_EXCEPTIONS
{
    class Bike : iTotalLost, iWhatIsMyBrand, iDoINeedRepair, iFixTotalLost
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }
        public int EngineVolume { get; private set; }


        public bool isTotalLost()
        {
            return this.TotalLost;
        }

        public bool DoINeedRepair()
        {
            return NeedsRepair;
        }

        public string WhatIsMyBrand()
        {
            return Brand;
        }

        public void ChangeRepair(bool NeedsRepair)
        {
            this.NeedsRepair = NeedsRepair;
        }

        public bool CanFixTotalLost()
        {
            return true;
        }
    }
}
