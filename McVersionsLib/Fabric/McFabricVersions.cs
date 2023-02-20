using System.Collections.Generic;
using System.Linq;
using System.Net;
using McVersionsLib.Core;

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
        /// <returns>List of all Fabric's loader version</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        public static List<string> GetAllLoaderVersions() 
        {
            List<string> result = new List<string>();

            if (FabricLoaderVersionsData == null || FabricLoaderVersionsData.Count == 0)
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

        /// <summary>
        /// Return all Fabric's loader versions for a specific Minecraft version
        /// </summary>
        /// <param name="targetedMcVersion">Targeted Minecraft version</param>
        /// <returns>List of all Fabric's loader version for the targetted minecraft version</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        /// <exception cref="VersionNotFoundException">No available Fabric versions for the targeted Minecraft</exception>
        public static List<string> GetAllLoaderVersions(string targetedMcVersion)
        {
            List<string> result = new List<string>();

            try
            {
                List<McFabricVersionDetailJsonEntry> versionsData = McFabricDataCollector.RetrieveFabricVersionsDetailsData(targetedMcVersion);

                if (versionsData == null || versionsData.Count == 0)
                    throw new VersionNotFoundException(string.Format("There are no available Fabric versions for Minecraft {0}", targetedMcVersion));

                result.AddRange(versionsData.Select(v => v.LoaderData.Version));
            }
            catch (WebException e)
            {
                throw e;
            }

            return result;
        }

        /// <summary>
        /// Return loader and mappings details for a specific Minecraft and loader version
        /// </summary>
        /// <param name="targetedMcVersion">Targeted Minecraft version</param>
        /// <param name="targetedLoaderVersion">Targeted loader version</param>
        /// <returns></returns>
        /// <exception cref="WebException">Cannot retrieve Fabric versions data</exception>
        /// <exception cref="VersionNotFoundException">No available Fabric versions for the targeted Minecraft</exception>
        /// <exception cref="VersionNotFoundException">The targeted loader version for the targeted Minecraft was not found</exception>
        public static McFabricVersionDetailJsonEntry GetLoaderAndMappingsDetails(string targetedMcVersion, string targetedLoaderVersion)
        {
            McFabricVersionDetailJsonEntry result;

            try
            {
                List<McFabricVersionDetailJsonEntry> versionsData = McFabricDataCollector.RetrieveFabricVersionsDetailsData(targetedMcVersion);

                if (versionsData == null || versionsData.Count == 0)
                    throw new VersionNotFoundException(string.Format("There are no available Fabric versions for Minecraft {0}", targetedMcVersion));

                McFabricVersionDetailJsonEntry targetedDetails = versionsData.FirstOrDefault(d => d.LoaderData.Version == targetedLoaderVersion);

                if(targetedDetails == null)
                    throw new VersionNotFoundException(string.Format("No loader version {0} for Minecraft {1} found", targetedLoaderVersion, targetedMcVersion));

                result = targetedDetails;
            }
            catch (WebException e)
            {
                throw e;
            }

            return result;
        }
    }
}
