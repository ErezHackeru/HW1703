using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW170319_TESTS_EXCEPTIONS
{
    public class Garage<T> : IGarage<T> where T: iTotalLost, iWhatIsMyBrand, iDoINeedRepair, iFixTotalLost
    {
        List<T> cars = new List<T>();
        List<string> carTypes = new List<string>();

        public Garage(List<string> carTypes)
        {
            this.carTypes = carTypes;
        }

        public void AddCar(T vehicle)
        {
            if (cars.Contains(vehicle))
                throw new VehicleAlreadyHereException("This Vehicle is already in the Garage");
            if (vehicle.isTotalLost() && !vehicle.CanFixTotalLost())
                throw new WeDoNotFixTotalLostException("This car is Total lost, and we don't fix these kind of cars");
            if (!carTypes.Contains(vehicle.WhatIsMyBrand()))
                throw new WrongGarageException($"This Garage does not treat {vehicle.WhatIsMyBrand()} vehicles kind.");
            if (vehicle == null)
                throw new CarNullException("The car given was empty!");
            if (!vehicle.DoINeedRepair())
                throw new RepairMismatchException("This car doesn't need treatment");
            cars.Add(vehicle);
        }

        public void FixCar(T vehicle)
        {
            if (vehicle == null)
                throw new CarNullException("The car given was empty!");
            if (!cars.Contains(vehicle))
                throw new CarNotInGarageException("This car is not in the Garage.");
            if (!vehicle.DoINeedRepair())
                throw new RepairMismatchException("This car doesn't need treatment");
            vehicle.ChangeRepair(false);
        }

        public void TakeOutCar(T vehicle)
        {
            if (vehicle == null)
                throw new CarNullException("The car given was empty!");
            if (!cars.Contains(vehicle))
                throw new CarNotInGarageException("This car is not in the Garage.");
            if (vehicle.DoINeedRepair())
                throw new CarNotReadyException("This car is not ready yet!");
            cars.Remove(vehicle);
        }
        
    }
}
