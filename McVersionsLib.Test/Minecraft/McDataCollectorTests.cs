using McVersionsLib.Minecraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
