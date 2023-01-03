using McVersionsLib.Core;
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
    /// Test class for McForgeVersions
    /// </summary>
    [TestClass]
    public class McForgeVersionsTests
    {
        #region GetAllSupportedMinecraftVersion
        [TestMethod]
        public void GetAllSupportedMinecraftVersionTestNotNull()
        {
            Assert.IsNotNull(McForgeVersions.GetAllSupportedMinecraftVersion());
        }

        [TestMethod]
        public void GetAllSupportedMinecraftVersionTest1192VersionExists()
        {
            List<string> supportedVersions = McForgeVersions.GetAllSupportedMinecraftVersion();
            Assert.IsNotNull(supportedVersions.FirstOrDefault(v => v.Equals("1.19.2")));
        }
        #endregion

        #region GetAllMinecraftForgeVersions
        [TestMethod]
        public void GetAllMinecraftForgeVersionsTestException1154()
        {
            Assert.ThrowsException<VersionNotFoundException>(() => McForgeVersions.GetAllMinecraftForgeVersions("1.15.4"));
        }

        [TestMethod]
        public void GetAllMinecraftForgeVersionsTestNotNull1192()
        {
            Assert.IsNotNull(McForgeVersions.GetAllMinecraftForgeVersions("1.19.2"));
        }

        [TestMethod]
        public void GetAllMinecraftForgeVersionsTest1192Forge43147()
        {
            List<string> availableMinecraftForgeVersions = McForgeVersions.GetAllMinecraftForgeVersions("1.19.2");
            Assert.IsNotNull(availableMinecraftForgeVersions.FirstOrDefault(v => v.Equals("1.19.2-43.1.47")));
        }
        #endregion

        #region GetRecommendedForgeVersion
        [TestMethod]
        public void GetRecommendedForgeVersionTest1132()
        {
            string recommendedVersion = McForgeVersions.GetRecommendedForgeVersion("1.13.2");
            Assert.IsTrue(string.IsNullOrEmpty(recommendedVersion));
        }
        #endregion
    }
}
