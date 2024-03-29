﻿using System.Collections.Generic;
using System.Net;
using McVersionsLib.Core;

namespace McVersionsLib.Forge
{
    /// <summary>
    /// Minecraft Forge versions functions
    /// </summary>
    public static class McForgeVersions
    {
        /// <summary>
        /// Minecraft Forge promoted versions data
        /// </summary>
        private static McForgePromotionsJson ForgePromotionsData { get; set; }

        /// <summary>
        /// Minecraft Forge available version data
        /// </summary>
        private static Dictionary<string, List<string>> ForgeAvailableVersionsData { get; set; }

        /// <summary>
        /// Return all Minecraft versions supported by Minecraft Forge
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>List of all Minecraft versions supported by Minecraft Forge</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        public static List<string> GetAllSupportedMinecraftVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if(ForgeAvailableVersionsData == null || forceRetrievingData)
            {
                try
                {
                    ForgeAvailableVersionsData = McForgeDataCollector.RetrieveAllAvailableMinecraftForgeVersionsData();
                }
                catch(WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(ForgeAvailableVersionsData.Keys);
            return result;
        }

        /// <summary>
        /// Return all available Minecraft Forge versions for a specific Minecraft version
        /// </summary>
        /// <param name="targetedMcVersion">Targeted Minecraft version</param>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>List of all available Minecraft Forge versions for the targetted Minecraft version</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        /// <exception cref="VersionNotFoundException">No available Minecraft Forge version for the taregetted Minecraft version</exception>
        public static List<string> GetAllMinecraftForgeVersions(string targetedMcVersion, bool forceRetrievingData = false)
        {
            List<string> availableMinecraftForgeVersions;

            if (ForgeAvailableVersionsData == null || forceRetrievingData)
            {
                try
                {
                    ForgeAvailableVersionsData = McForgeDataCollector.RetrieveAllAvailableMinecraftForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            if (ForgeAvailableVersionsData.TryGetValue(targetedMcVersion, out availableMinecraftForgeVersions))
                return availableMinecraftForgeVersions;

            throw new VersionNotFoundException(string.Format("There are no available Minecraft Forge versions for Minecraft {0}", targetedMcVersion));
        }

        /// <summary>
        /// Return recommanded Minecraft Forge version for a specific Minecraft version
        /// </summary>
        /// <param name="targetedMcVersion">Targeted Minecraft version</param>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>Recommended version of Minecraft Forge for the specific Minecraft version, or <c>string.Empty</c> if no recommended version is available</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        public static string GetRecommendedMinecraftForgeVersion(string targetedMcVersion, bool forceRetrievingData = false)
        {
            string recommendedVersion;

            if(ForgePromotionsData == null || forceRetrievingData)
            {
                try
                {
                    ForgePromotionsData = McForgeDataCollector.RetrievePromotedMinecraftForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            if (ForgePromotionsData.Promos.TryGetValue(string.Concat(targetedMcVersion, "-recommended"), out recommendedVersion))
                return recommendedVersion;

            return string.Empty;
        }

        /// <summary>
        /// Return latest Minecraft Forge version for a specific Minecraft version
        /// </summary>
        /// <param name="targetedMcVersion">Targeted Minecraft version</param>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>Latest version of Minecraft Forge for the specific Minecraft version, or <c>string.Empty</c> if no latest version is available</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        public static string GetLatestMinecraftForgeVersion(string targetedMcVersion, bool forceRetrievingData = false)
        {
            string recommendedVersion;

            if (ForgePromotionsData == null || forceRetrievingData)
            {
                try
                {
                    ForgePromotionsData = McForgeDataCollector.RetrievePromotedMinecraftForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            if (ForgePromotionsData.Promos.TryGetValue(string.Concat(targetedMcVersion, "-latest"), out recommendedVersion))
                return recommendedVersion;

            return string.Empty;
        }
    }
}
