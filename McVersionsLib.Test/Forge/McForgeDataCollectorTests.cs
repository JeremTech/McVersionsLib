using McVersionsLib.Forge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
