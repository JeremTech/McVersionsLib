using McVersionsLib.Forge;
using McVersionsLib.Minecraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McVersionsLib.Test.Minecraft
{
    /// <summary>
    /// Test class for McForgeDataCollector
    /// </summary>
    [TestClass]
    public class McDataCollectorTests
    {
        [TestMethod]
        public void RetrieveAllAvailableMinecraftVersionsDataTest()
        {
            var data = McDataCollector.RetrieveAllAvailableMinecraftVersionsData();

            Assert.IsNotNull(data);
            Assert.IsTrue(data.AllVersionsData.Count > 0);
        }
    }
}
