using McVersionsLib.Core;
using McVersionsLib.Fabric;
using McVersionsLib.Forge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McVersionsLib.Test.Fabric
{
    /// <summary>
    /// Test class for McFabricVersions
    /// </summary>
    [TestClass]
    public class McFabricVersionsTests
    {
        #region GetAllSupportedMinecraftVersions
        [TestMethod]
        public void GetAllSupportedMinecraftVersionsTestNotNull()
        {
            Assert.IsNotNull(McFabricVersions.GetAllSupportedMinecraftVersions());
        }

        [TestMethod]
        public void GetAllSupportedMinecraftVersionsTest1193VersionExists()
        {
            List<string> supportedVersions = McFabricVersions.GetAllSupportedMinecraftVersions();
            Assert.IsNotNull(supportedVersions.FirstOrDefault(v => v.Equals("1.19.3")));
        }
        #endregion

        #region GetAllSupportedStableMinecraftVersions
        [TestMethod]
        public void GetAllSupportedStableMinecraftVersionsTestNotNull()
        {
            Assert.IsNotNull(McFabricVersions.GetAllSupportedStableMinecraftVersions());
        }

        [TestMethod]
        public void GetAllSupportedStableMinecraftVersionsTest1193VersionExists()
        {
            List<string> supportedVersions = McFabricVersions.GetAllSupportedStableMinecraftVersions();
            Assert.IsNotNull(supportedVersions.FirstOrDefault(v => v.Equals("1.19.3")));
        }

        [TestMethod]
        public void GetAllSupportedStableMinecraftVersionsTestVersion22w44aNotExists()
        {
            List<string> supportedVersions = McFabricVersions.GetAllSupportedStableMinecraftVersions();
            Assert.IsNull(supportedVersions.FirstOrDefault(v => v.Equals("22w44a")));
        }
        #endregion

        #region GetAllSupportedUnstableMinecraftVersions
        [TestMethod]
        public void GetAllSupportedUnstableMinecraftVersionsTestNotNull()
        {
            Assert.IsNotNull(McFabricVersions.GetAllSupportedUnstableMinecraftVersions());
        }

        [TestMethod]
        public void GetAllSupportedUnstableMinecraftVersionsTestVersion22w44aExists()
        {
            List<string> supportedVersions = McFabricVersions.GetAllSupportedUnstableMinecraftVersions();
            Assert.IsNotNull(supportedVersions.FirstOrDefault(v => v.Equals("22w44a")));
        }

        [TestMethod]
        public void GetAllSupportedUnstableMinecraftVersionsTest1193VersionNotExists()
        {
            List<string> supportedVersions = McFabricVersions.GetAllSupportedUnstableMinecraftVersions();
            Assert.IsNull(supportedVersions.FirstOrDefault(v => v.Equals("1.19.3")));
        }
        #endregion

        #region GetAllLoaderVersions
        [TestMethod]
        public void GetAllLoaderVersionsTestNotNull()
        {
            Assert.IsNotNull(McFabricVersions.GetAllLoaderVersions());
        }

        [TestMethod]
        [ExpectedException(typeof(VersionNotFoundException))]
        public void GetAllLoaderVersionsSpecificMinecraftVersionTestMinecraftVersionNotFound()
        {
            McFabricVersions.GetAllLoaderVersions("1.17.5");
        }

        [TestMethod]
        public void GetAllLoaderVersionsSpecificMinecraftVersionTestNotNull()
        {
            Assert.IsNotNull(McFabricVersions.GetAllLoaderVersions("1.19.3"));
        }

        [TestMethod]
        public void GetAllLoaderVersionsSpecificMinecraftVersionTestContainsVersion()
        {
            var versionsData = McFabricVersions.GetAllLoaderVersions("1.19.3");
            Assert.IsTrue(versionsData.Contains("0.14.13"));
        }
        #endregion

        #region GetLoaderAndMappingsDetails
        [TestMethod]
        [ExpectedException(typeof(VersionNotFoundException))]
        public void GetLoaderAndMappingsDetailsTestMinecraftVersionNotFound()
        {
            McFabricVersions.GetLoaderAndMappingsDetails("1.18.7", "0.14.13");
        }

        [TestMethod]
        [ExpectedException(typeof(VersionNotFoundException))]
        public void GetLoaderAndMappingsDetailsTestLoaderVersionNotFound()
        {
            McFabricVersions.GetLoaderAndMappingsDetails("1.19.3", "6.14.13");
        }

        [TestMethod]
        public void GetLoaderAndMappingsDetailsTestContainsVersion()
        {
            var versionDetails = McFabricVersions.GetLoaderAndMappingsDetails("1.19.3", "0.14.13");
            Assert.IsNotNull(versionDetails);
        }
        #endregion
    }
}
