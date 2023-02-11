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
    [TestClass]
    public class McVersionsTests
    {
        #region GetAllAvailableMinecraftVersions
        [TestMethod]
        public void GetAllAvailableMinecraftVersionsTestNotNull()
        {
            Assert.IsNotNull(McVersions.GetAllAvailableMinecraftVersions());
        }

        [TestMethod]
        public void GetAllAvailableMinecraftVersionsTestContainsRelease()
        {
            var data = McVersions.GetAllAvailableMinecraftVersions();
            Assert.IsTrue(data.Contains("1.19.3"));
        }

        [TestMethod]
        public void GetAllAvailableMinecraftVersionsTestContainsSnapshot()
        {
            var data = McVersions.GetAllAvailableMinecraftVersions();
            Assert.IsTrue(data.Contains("23w05a"));
        }

        [TestMethod]
        public void GetAllAvailableMinecraftVersionsTestContainsBeta()
        {
            var data = McVersions.GetAllAvailableMinecraftVersions();
            Assert.IsTrue(data.Contains("b1.7.3"));
        }

        [TestMethod]
        public void GetAllAvailableMinecraftVersionsTestContainsAlpha()
        {
            var data = McVersions.GetAllAvailableMinecraftVersions();
            Assert.IsTrue(data.Contains("rd-132328"));
        }
        #endregion

        #region GetAllAvailableMinecraftReleaseVersions
        [TestMethod]
        public void GetAllAvailableMinecraftReleaseVersionsTestContainsVersion()
        {
            var data = McVersions.GetAllAvailableMinecraftReleaseVersions();
            Assert.IsTrue(data.Contains("1.19.3"));
        }

        [TestMethod]
        public void GetAllAvailableMinecraftReleaseVersionsTestNotContainsVersion()
        {
            var data = McVersions.GetAllAvailableMinecraftReleaseVersions();
            Assert.IsFalse(data.Contains("23w05a"));
        }
        #endregion

        #region GetAllAvailableMinecraftSnapshotVersions
        [TestMethod]
        public void GetAllAvailableMinecraftSnapshotVersionsTestContainsVersion()
        {
            var data = McVersions.GetAllAvailableMinecraftSnapshotVersions();
            Assert.IsTrue(data.Contains("23w05a"));
        }

        [TestMethod]
        public void GetAllAvailableMinecraftSnapshotVersionsTestNotContainsVersion()
        {
            var data = McVersions.GetAllAvailableMinecraftSnapshotVersions();
            Assert.IsFalse(data.Contains("1.19.3"));
        }
        #endregion
    }
}
