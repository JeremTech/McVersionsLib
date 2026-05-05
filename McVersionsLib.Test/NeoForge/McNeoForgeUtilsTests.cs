using McVersionsLib.NeoForge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McVersionsLib.Test.NeoForge
{
    /// <summary>
    /// Test class for McNeoForgeUtils
    /// </summary>
    [TestClass]
    public class McNeoForgeUtilsTests
    {
        [TestMethod]
        public void GetNeoForgeVersionFromMinecraftVersionMinorMcVersionTest()
        {
            Assert.AreEqual("20.4", McNeoForgeUtils.GetNeoForgeVersionFromMinecraftVersion("1.20.4"));
        }

        [TestMethod]
        public void GetNeoForgeVersionFromMinecraftVersionMajorMcVersionTest()
        {
            Assert.AreEqual("20.0", McNeoForgeUtils.GetNeoForgeVersionFromMinecraftVersion("1.20"));
        }

        [TestMethod]
        public void GetNeoForgeVersionFromMinecraftVersionNewVersioningSystemTest()
        {
            Assert.AreEqual("26.1", McNeoForgeUtils.GetNeoForgeVersionFromMinecraftVersion("26.1"));
        }
    }
}
