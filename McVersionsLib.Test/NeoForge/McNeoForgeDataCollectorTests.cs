using McVersionsLib.Forge;
using McVersionsLib.NeoForge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            Assert.ThrowsException<WebException>(() => McNeoForgeDataCollector.RetrieveNeoForgeLatestVersionData("19.4"));
        }
    }
}
