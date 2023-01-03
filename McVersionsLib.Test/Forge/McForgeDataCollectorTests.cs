using McVersionsLib.Forge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McVersionsLib.Test.Forge
{
    /// <summary>
    /// Test class for McForgeDataCollector
    /// </summary>
    [TestClass]
    public class McForgeDataCollectorTests
    {
        [TestMethod]
        public void RetrieveAllAvailableMinecraftForgeVersionsDataTest()
        {
            Assert.IsNotNull(McForgeDataCollector.RetrieveAllAvailableMinecraftForgeVersionsData());
        }

        [TestMethod]
        public void RetrievePromotedMinecraftForgeVersionsData()
        {
            Assert.IsNotNull(McForgeDataCollector.RetrievePromotedMinecraftForgeVersionsData());
        }
    }
}
