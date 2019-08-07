using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170319_TESTS_EXCEPTIONS
{
    public interface iTotalLost
    {
        bool isTotalLost();
    }

    public interface iFixTotalLost
    {
        bool CanFixTotalLost();
    }

    public interface iWhatIsMyBrand
    {
        string WhatIsMyBrand();
    }

    public interface iDoINeedRepair
    {
        bool DoINeedRepair();
        void ChangeRepair(bool NeedsRepair);
    }
}
