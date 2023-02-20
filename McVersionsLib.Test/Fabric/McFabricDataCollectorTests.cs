using McVersionsLib.Fabric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McVersionsLib.Test.Fabric
{
    /// <summary>
    /// Test class for McFabricDataCollector
    /// </summary>
    [TestClass]
    public class McFabricDataCollectorTests
    {
        [TestMethod]
        public void RetrieveFabricGameVersionsDataTest()
        {
            var data = McFabricDataCollector.RetrieveFabricGameVersionsData();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void RetrieveFabricLoaderVersionsDataTest()
        {
            var data = McFabricDataCollector.RetrieveFabricLoaderVersionsData();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void RetrieveFabricVersionsDetailsData()
        {
            var data = McFabricDataCollector.RetrieveFabricVersionsDetailsData("1.19.3");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }
    }
}
