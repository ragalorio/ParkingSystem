using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Tests
{
    [TestClass()]
    public class ParkingMathProcessTests
    {
        [TestMethod()]
        public void AddProcessTest()
        {
            ParkingMathProcess parkProcess = new ParkingMathProcess();
            Assert.AreEqual(3, parkProcess.AddProcess(1, 2));
        }

        [TestMethod()]
        public void SubProcessTest()
        {
            ParkingMathProcess parkProcess = new ParkingMathProcess();
            Assert.AreEqual(3, parkProcess.SubProcess(1, 2));
        }
    }
}