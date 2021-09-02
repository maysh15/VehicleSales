using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VehicleSales.Logic;
using VehicleSales.Model;

namespace VehicleSales.Tests
{
    [TestClass]
    public class VehicleSalesUnitTests
    {
        private List<VehicleDeal> vehicleList;

        [TestInitialize]
        public void TestInitialize()
        {
            this.vehicleList = LoadTestVehicleDeals();
        }

        [TestMethod]
        public void TestCurrencyFormatting()
        {
            string result = Formatter.RemoveCurrencyFormatting("\"123,890\"");

            Assert.AreEqual("123890", result);
        }

        [TestMethod]
        public void VechieDealFilter_MostSoldVehicle()
        {
            string result = VehicleDealFilter.MostSoldVehicle(this.vehicleList);

            Assert.AreEqual("2018 Toyota", result);
        }

        private List<VehicleDeal> LoadTestVehicleDeals()
        {
            var lstVehicle = new List<VehicleDeal>();

            var vehicleDealFirst = new VehicleDeal();
            vehicleDealFirst.CustomerName = "a";
            vehicleDealFirst.Vehicle = "2015 Toyota";

            var vehicleDealSecond = new VehicleDeal();
            vehicleDealSecond.CustomerName = "b";
            vehicleDealSecond.Vehicle = "2018 Toyota";

            var vehicleDealThird = new VehicleDeal();
            vehicleDealThird.CustomerName = "c";
            vehicleDealThird.Vehicle = "2018 Toyota"

            lstVehicle.Add(vehicleDealFirst);
            lstVehicle.Add(vehicleDealSecond);
            lstVehicle.Add(vehicleDealThird);

            return lstVehicle;
        }
    }
}
