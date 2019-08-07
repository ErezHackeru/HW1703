using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170319_TESTS_EXCEPTIONS
{
    public class Car : iTotalLost, iWhatIsMyBrand, iDoINeedRepair, iFixTotalLost
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;

            if (this.TotalLost && !this.NeedsRepair)
                throw new RepairMismatchException("It can't be that car is total lost and does't need e");
        }

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
            return false;
        }
    }
}
