using McVersionsLib.NeoForge;
using System.Net;

namespace McVersionsLib.Test.NeoForge
{
    /// <summary>
    /// Test class for McNeoForgeDataCollector
    /// </summary>
    [TestClass]
    public class McNeoForgeDataCollectorTests
    {
        [TestMethod]
        public void RetrieveNeoForgeVersionsDataTest()
        {
            Assert.IsNotNull(McNeoForgeDataCollector.RetrieveNeoForgeVersionsData());
            Assert.IsTrue(McNeoForgeDataCollector.RetrieveNeoForgeVersionsData().Count > 0);
        }

        [TestMethod]
        public void RetrieveNeoForgeLatestVersionDataTest()
        {
            Assert.IsNotNull(McNeoForgeDataCollector.RetrieveNeoForgeLatestVersionData("20.4"));
        }

        [TestMethod]
        public void RetrieveNeoForgeLatestVersionDataExceptionTest()
        {
            Assert.ThrowsExactly<WebException>(() => McNeoForgeDataCollector.RetrieveNeoForgeLatestVersionData("19.4"));
        }
    }
}
