using System;
using System.Collections.Generic;
using HW170319_TESTS_EXCEPTIONS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_API
{
    [TestClass]
    public class GarageTest
    {
        static List<string> new_car_brands = new List<string>()
            {
                "BMW", "Skoda" , "Subaro", "Ferrari"
            };
        Garage<Car> g = new Garage<Car>(new_car_brands);

        /// <summary>
        /// =================================================================
        /// AddCar Method Tests
        /// =================================================================
        /// </summary>
        [TestMethod]
        public void TestAddCarMethod0()
        {
            Car c1 = new Car("Skoda", false, true);
            g.AddCar(c1);
        }
        [TestMethod]
        [ExpectedException(typeof(VehicleAlreadyHereException))]
        public void TestAddCarMethod1()
        {
            Car c1 = new Car("Skoda", false, true);            
            g.AddCar(c1);
            g.AddCar(c1);
        }

        [TestMethod]
        [ExpectedException(typeof(WeDoNotFixTotalLostException))]
        public void TestAddCarMethod2()
        {
            Car c1 = new Car("Skoda", true, true);
            g.AddCar(c1);
        }
        [TestMethod]
        [ExpectedException(typeof(WrongGarageException))]
        public void TestAddCarMethod3()
        {
            Car c1 = new Car("Honda", false, true);
            g.AddCar(c1);
        }
        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void TestAddCarMethod4()
        {
            Car c1 = new Car("Skoda", false, false);
            g.AddCar(c1);
        }
        /// <summary>
        /// =================================================================
        /// TakeOutCar Method Tests
        /// =================================================================
        /// </summary>
        [TestMethod]        
        public void TestTakeOutCarMethod0()
        {
            Car c1 = new Car("Skoda", false, true);
            g.AddCar(c1);
            c1.NeedsRepair = false;
            g.TakeOutCar(c1);
        }
        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void TestTakeOutCarMethod1()
        {
            Car c = null;
            g.TakeOutCar(c);
        }
        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void TestTakeOutCarMethod2()
        {
            Car c1 = new Car("Skoda", false, true);
            Car c2 = new Car("Honda", false, true);
            g.AddCar(c1);
            g.TakeOutCar(c2);
        }
        [TestMethod]
        [ExpectedException(typeof(CarNotReadyException))]
        public void TestTakeOutCarMethod3()
        {
            Car c1 = new Car("Skoda", false, true);
            g.AddCar(c1);
            g.TakeOutCar(c1);
        }
        /// <summary>
        /// =================================================================
        /// FixCar Method Tests
        /// =================================================================
        /// </summary>
        [TestMethod]        
        public void TestFixCarMethod0()
        {
            Car c1 = new Car("Skoda", false, true);
            g.AddCar(c1);
            g.FixCar(c1);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void TestFixCarMethod1()
        {
            Car c1 = null;
            g.FixCar(c1);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void TestFixCarMethod2()
        {
            Car c1 = new Car("Skoda", false, true);
            Car c2 = new Car("Citroen", false, false);
            g.AddCar(c1);
            g.FixCar(c2);
        }

        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void TestFixCarMethod3()
        {
            Car c1 = new Car("Skoda", false, false);
            g.AddCar(c1);
            g.TakeOutCar(c1);
        }
    }
}
