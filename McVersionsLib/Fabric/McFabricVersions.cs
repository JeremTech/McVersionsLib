using McVersionsLib.Forge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace McVersionsLib.Fabric
{
    /// <summary>
    /// Fabric versions functions
    /// </summary>
    public static class McFabricVersions
    {
        /// <summary>
        /// Fabric game versions data
        /// </summary>
        private static List<McFabricGameVersionJsonEntry> FabricGameVersionsData { get; set; }

        /// <summary>
        /// Fabric loader versions data
        /// </summary>
        private static List<McFabricLoaderVersionJsonEntry> FabricLoaderVersionsData { get; set; }

        /// <summary>
        /// Return all Minecraft versions supported by Fabric
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Fabric official website</param>
        /// <returns>List of all Minecraft versions supported by Fabric</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        public static List<string> GetAllSupportedMinecraftVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (FabricGameVersionsData == null || FabricGameVersionsData.Count == 0 || forceRetrievingData)
            {
                try
                {
                    FabricGameVersionsData = McFabricDataCollector.RetrieveFabricGameVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(FabricGameVersionsData.Select(v => v.Version));
            return result;
        }

        /// <summary>
        /// Return all stable Minecraft versions supported by Fabric
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Fabric official website</param>
        /// <returns>List of all stable Minecraft versions supported by Fabric</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        public static List<string> GetAllSupportedStableMinecraftVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (FabricGameVersionsData == null || FabricGameVersionsData.Count == 0 || forceRetrievingData)
            {
                try
                {
                    FabricGameVersionsData = McFabricDataCollector.RetrieveFabricGameVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(FabricGameVersionsData.Where(v => v.Stable).Select(v => v.Version));
            return result;
        }

        /// <summary>
        /// Return all unstable Minecraft versions supported by Fabric
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Fabric official website</param>
        /// <returns>List of all unstable Minecraft versions supported by Fabric</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        public static List<string> GetAllSupportedUnstableMinecraftVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (FabricGameVersionsData == null || FabricGameVersionsData.Count == 0 || forceRetrievingData)
            {
                try
                {
                    FabricGameVersionsData = McFabricDataCollector.RetrieveFabricGameVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(FabricGameVersionsData.Where(v => !v.Stable).Select(v => v.Version));
            return result;
        }

        /// <summary>
        /// Return all Fabric's loader versions
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Fabric official website</param>
        /// <returns>List of all Fabric's loader version</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        public static List<string> GetAllLoaderVersions(bool forceRetrievingData = false) 
        {
            List<string> result = new List<string>();

            if (FabricLoaderVersionsData == null || FabricLoaderVersionsData.Count == 0 || forceRetrievingData)
            {
                try
                {
                    FabricLoaderVersionsData = McFabricDataCollector.RetrieveFabricLoaderVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(FabricLoaderVersionsData.Select(v => v.Version));
            return result;
        }
    }
}
