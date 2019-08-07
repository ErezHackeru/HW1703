using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170319_TESTS_EXCEPTIONS
{
    public interface IGarage<T>
    {
        void FixCar(T vehicle);
        void TakeOutCar(T vehicle);
        void AddCar(T vehicle);
    }
}
