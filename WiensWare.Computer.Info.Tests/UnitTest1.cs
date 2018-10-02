using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WiensWare.Computer;

namespace WiensWare.Computer.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ComputerName_IsValidString()
        {
            // Get value from method
            string computerName = Info.GetComputerName();

            // Test returned value to make sure it's valid
            Assert.IsNotNull(computerName);
            Assert.IsTrue(computerName.Length > 0);
            Assert.IsTrue(computerName.Length < 16);
        }

        [TestMethod]
        public void Memory_IsValid()
        {
            // Get value from method
            string strMemory = Info.GetMemory();
            UInt64 intMemory = UInt64.Parse(strMemory);

            // Test returned value to make sure it's valid
            Assert.IsTrue(intMemory > 0ul);
        }
    }
}
