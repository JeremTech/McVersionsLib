using McVersionsLib.NeoForge;
using System.Net;

namespace McVersionsLib.Test.NeoForge
{
    [TestClass]
    public class McNeoForgeVersionsTests
    {
        [TestMethod]
        public void GetAllNeoForgeVersionsTest()
        {
            Assert.IsTrue(McNeoForgeVersions.GetAllNeoForgeVersions().Contains("20.4.60-beta"));
            Assert.IsTrue(McNeoForgeVersions.GetAllNeoForgeVersions().Contains("20.2.60-beta"));
        }

        [TestMethod]
        public void GetAllNeoForgeVersionsSpecificMinecraftVersionTest()
        {
            Assert.IsTrue(McNeoForgeVersions.GetAllNeoForgeVersions("1.20.4").Contains("20.4.60-beta"));
            Assert.IsFalse(McNeoForgeVersions.GetAllNeoForgeVersions("1.20.4").Contains("20.2.60-beta"));
        }

        [TestMethod]
        public void GetLatestNeoForgeVersionExistTest()
        {
            Assert.IsFalse(string.IsNullOrEmpty(McNeoForgeVersions.GetLatestNeoForgeVersion("1.20.4")));
        }

        [TestMethod]
        public void GetLatestNeoForgeVersionNotExistTest()
        {
            Assert.ThrowsExactly<WebException>(() => McNeoForgeVersions.GetLatestNeoForgeVersion("1.19.4"));
        }
    }
}
