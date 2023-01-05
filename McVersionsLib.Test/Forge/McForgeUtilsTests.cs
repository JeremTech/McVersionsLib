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
    /// Test class for McForgeUtils
    /// </summary>
    [TestClass]
    public class McForgeUtilsTests
    {
        #region BuildMinecraftForgeMDKDownloadLink
        [TestMethod]
        public void BuildMinecraftForgeMDKDownloadLinkTest()
        {
            string excepted = "https://files.minecraftforge.net/maven/net/minecraftforge/forge/1.19.2-43.1.47/forge-1.19.2-43.1.47-mdk.zip";
            Assert.AreEqual(excepted, McForgeUtils.BuildMinecraftForgeMDKDownloadLink("1.19.2-43.1.47"));
        }
        #endregion

        #region BuildMinecraftForgeMDKDownloadLink
        [TestMethod]
        public void BuildMinecraftForgeInstallerLink()
        {
            string excepted = "https://files.minecraftforge.net/maven/net/minecraftforge/forge/1.19.2-43.1.47/forge-1.19.2-43.1.47-installer.jar";
            Assert.AreEqual(excepted, McForgeUtils.BuildMinecraftForgeInstallerLink("1.19.2-43.1.47"));
        }
        #endregion
    }
}
