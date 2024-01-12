using McVersionsLib.Forge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace McVersionsLib.NeoForge
{
    /// <summary>
    /// NeoForge versions functions
    /// </summary>
    public static class McNeoForgeVersions
    {
        /// <summary>
        /// NeoForge versions list
        /// </summary>
        private static List<string> NeoForgeVersions { get; set; }

        /// <summary>
        /// Return all NeoForge versions
        /// </summary>
        /// <param name="forceRetrievingData">Force retrieving data from Forge official website</param>
        /// <returns>List of all NeoForge versions</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        public static List<string> GetAllNeoForgeVersions(bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (NeoForgeVersions == null || forceRetrievingData)
            {
                try
                {
                    NeoForgeVersions = McNeoForgeDataCollector.RetrieveNeoForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(NeoForgeVersions);
            return result;
        }

        /// <summary>
        /// Return all NeoForge versions for a specific Minecraft version
        /// </summary>
        /// <param name="mcVersion">Targeted Minecraft version</param>
        /// <param name="forceRetrievingData">Force retrieving data from NeoForge official website</param>
        /// <returns>List of all NeoForge versions</returns>
        /// <exception cref="WebException">Cannot retrieve NeoForge versions data</exception>
        public static List<string> GetAllNeoForgeVersions(string mcVersion, bool forceRetrievingData = false)
        {
            List<string> result = new List<string>();

            if (NeoForgeVersions == null || forceRetrievingData)
            {
                try
                {
                    NeoForgeVersions = McNeoForgeDataCollector.RetrieveNeoForgeVersionsData();
                }
                catch (WebException e)
                {
                    throw e;
                }
            }

            result.AddRange(NeoForgeVersions.Where(v => v.StartsWith(McNeoForgeUtils.GetNeoForgeVersionFromMinecraftVersion(mcVersion))));
            return result;
        }

        /// <summary>
        /// Return the latest NeoForge version for a specific Minecraft version
        /// </summary>
        /// <param name="mcVersion">Targeted Minecraft version</param>
        /// <returns>Latest NeoForge version for the targeted Minecraft version</returns>
        /// <exception cref="WebException">Cannot retrieve NeoForge versions data</exception>
        public static string GetLatestNeoForgeVersion(string mcVersion)
        {
            try
            {
                return McNeoForgeDataCollector.RetrieveNeoForgeLatestVersionData(McNeoForgeUtils.GetNeoForgeVersionFromMinecraftVersion(mcVersion));
            }
            catch (WebException e)
            {
                throw e;
            }
        }
    }
}
