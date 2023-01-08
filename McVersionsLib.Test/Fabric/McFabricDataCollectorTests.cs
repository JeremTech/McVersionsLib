﻿using McVersionsLib.Fabric;
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
    /// Test class for McFabricDataCollector
    /// </summary>
    [TestClass]
    public class McFabricDataCollectorTests
    {
        [TestMethod]
        public void RetrieveFabricGameVersionsDataTest()
        {
            var data = McFabricDataCollector.RetrieveFabricGameVersionsData();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }
    }
}
