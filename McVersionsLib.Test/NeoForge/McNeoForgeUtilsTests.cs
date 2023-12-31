using McVersionsLib.NeoForge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
