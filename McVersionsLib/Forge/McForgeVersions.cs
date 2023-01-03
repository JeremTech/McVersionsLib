using McVersionsLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace McVersionsLib.Forge
{
    public static class McForgeVersions
    {
        /// <summary>
        /// Minecraft Forge promoted versions data
        /// </summary>
        private static ForgePromotionsJson forgePromotionsData { get; set; }

        /// <summary>
        /// Minecraft Forge available version data
        /// </summary>
        private static Dictionary<string, List<string>> forgeAvailableVersionsData { get; set; }

        /// <summary>
        /// Return all Minecraft versions supported by Minecraft Forge
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>List of all Minecraft versions supported by Minecraft Forge</returns>
        /// <exception cref="WebException">Cannot retreive Forge versions data</exception>
        public static List<string> GetAllSupportedMinecraftVersion(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if(forgeAvailableVersionsData == null || forceRetrievingData)
            {
                try
                {
                    forgeAvailableVersionsData = McForgeDataCollector.RetrieveAllAvailableMinecraftForgeVersionsData();
                }
                catch(WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(forgeAvailableVersionsData.Keys);
            return result;
        }

        /// <summary>
        /// Return all available Minecraft Forge versions for a specific Minecraft version
        /// </summary>
        /// <param name="targettedMcVersion">Targetted Minecraft version</param>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>List of all available Minecraft Forge versions for the targetted Minecraft version</returns>
        /// <exception cref="WebException">Cannot retreive Forge versions data</exception>
        /// <exception cref="VersionNotFoundException">No available Minecraft Forge version for the taregetted Minecraft version</exception>
        public static List<string> GetAllMinecraftForgeVersions(string targettedMcVersion, bool forceRetrievingData = false)
        {
            List<string> availableMinecraftForgeVersions;

            if (forgeAvailableVersionsData == null || forceRetrievingData)
            {
                try
                {
                    forgeAvailableVersionsData = McForgeDataCollector.RetrieveAllAvailableMinecraftForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            if (forgeAvailableVersionsData.TryGetValue(targettedMcVersion, out availableMinecraftForgeVersions))
                return availableMinecraftForgeVersions;

            throw new VersionNotFoundException(string.Format("There are no available Minecraft Forge versions for Minecraft {0}", targettedMcVersion));
        }

        /// <summary>
        /// Return recommanded Minecraft Forge version for a specific Minecraft version
        /// </summary>
        /// <param name="targettedMcVersion">Targetted Minecraft version</param>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>Recommended version of Minecraft Forge fort the specific Minecraft version, or <c>string.Empty</c> if no recommended version is available</returns>
        /// <exception cref="WebException">Cannot retreive Forge versions data</exception>
        public static string GetRecommendedForgeVersion(string targettedMcVersion, bool forceRetrievingData = false)
        {
            string recommendedVersion;

            if(forgePromotionsData == null || forceRetrievingData)
            {
                try
                {
                    forgePromotionsData = McForgeDataCollector.RetrievePromotedMinecraftForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            if (forgePromotionsData.Promos.TryGetValue(targettedMcVersion, out recommendedVersion))
                return recommendedVersion;

            return string.Empty;
        }
    }
}
