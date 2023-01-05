using System;
using System.Collections.Generic;
using System.Text;

namespace McVersionsLib.Fabric
{
    /// <summary>
    /// Fabric data collector class
    /// </summary>
    public static class McFabricDataCollector
    {
        /// <summary>
        /// URL to Fabric's supported game versions JSON
        /// </summary>
        private static readonly string gameVersionsUrl = "https://meta.fabricmc.net/v1/versions/game";

        /// <summary>
        /// URL to Fabric's loader versions JSON
        /// </summary>
        private static readonly string loaderVersionsUrl = "https://meta.fabricmc.net/v1/versions/loader/";
    }
}
