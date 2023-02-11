using McVersionsLib.Forge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace McVersionsLib.Minecraft
{
    /// <summary>
    /// Minecraft versions functions
    /// </summary>
    public static class McVersions
    {
        /// <summary>
        /// Minecraft versions data
        /// </summary>
        private static McVersionManifestJson MinecraftVersionsData { get; set; }

        /// <summary>
        /// Return all available Minecraft versions
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Mojang Studios servers</param>
        /// <returns>List of all available Minecraft versions (releases, snapshots, betas and alphas) ordered by release date (descending)</returns>
        /// <exception cref="WebException">Cannot retrieve Minecraft versions data</exception>
        public static List<string> GetAllAvailableMinecraftVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (MinecraftVersionsData == null || forceRetrievingData)
            {
                try
                {
                    MinecraftVersionsData = McDataCollector.RetrieveAllAvailableMinecraftVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(MinecraftVersionsData.AllVersionsData.OrderByDescending(v => v.ReleaseDate)
                                                                 .Select(v => v.Version));
            return result;
        }

        /// <summary>
        /// Return all available Minecraft release versions
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Mojang Studios servers</param>
        /// <returns>List of all available Minecraft release versions ordered by release date (descending)</returns>
        /// <exception cref="WebException">Cannot retrieve Minecraft versions data</exception>
        public static List<string> GetAllAvailableMinecraftReleaseVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (MinecraftVersionsData == null || forceRetrievingData)
            {
                try
                {
                    MinecraftVersionsData = McDataCollector.RetrieveAllAvailableMinecraftVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(MinecraftVersionsData.AllVersionsData.OrderByDescending(v => v.ReleaseDate)
                                                                 .Where(v => v.VersionType == McVersionType.Release)
                                                                 .Select(v => v.Version));
            return result;
        }

        /// <summary>
        /// Return all available Minecraft snapshot versions
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Mojang Studios servers</param>
        /// <returns>List of all available Minecraft snapshot versions ordered by release date (descending)</returns>
        /// <exception cref="WebException">Cannot retrieve Minecraft versions data</exception>
        public static List<string> GetAllAvailableMinecraftSnapshotVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (MinecraftVersionsData == null || forceRetrievingData)
            {
                try
                {
                    MinecraftVersionsData = McDataCollector.RetrieveAllAvailableMinecraftVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(MinecraftVersionsData.AllVersionsData.OrderByDescending(v => v.ReleaseDate)
                                                                 .Where(v => v.VersionType == McVersionType.Snapshot)
                                                                 .Select(v => v.Version));
            return result;
        }
    }
}
