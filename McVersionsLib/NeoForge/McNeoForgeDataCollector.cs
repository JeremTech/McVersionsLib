using McVersionsLib.Fabric;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace McVersionsLib.NeoForge
{
    /// <summary>
    /// NeoForge data collector class
    /// </summary>
    public static class McNeoForgeDataCollector
    {
        /// <summary>
        /// URL to all NeoForge's versions
        /// </summary>
        private static readonly string neoForgeVersionsUrl = "https://maven.neoforged.net/api/maven/versions/releases/net/neoforged/neoforge";

        /// <summary>
        /// Base URL to latest NeoForge's version
        /// </summary>
        private static readonly string neoForgeLatestVersionBaseUrl = "https://maven.neoforged.net/api/maven/latest/version/releases/net%2Fneoforged%2Fneoforge?filter=";

        /// <summary>
        /// Retrieve NeoForge versions data from the official project's website
        /// </summary>
        /// <returns>List of NeoForge's versions</returns>
        /// <exception cref="WebException">Cannot retrieve NeoForge versions data</exception>
        public static List<string> RetrieveNeoForgeVersionsData()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(neoForgeVersionsUrl);

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<McNeoForgeVersionsJson>(jsonRawContent).Versions;

                throw new WebException("Cannot retrieve available NeoForge versions data. Please check your Internet connection.");
            }
        }

        /// <summary>
        /// Retrieve NeoForge latest version data from the official project's website for a specified NeoForge major version
        /// </summary>
        /// <param name="neoForgeVersion">Targeted major version of NeoForge</param>
        /// <returns>Latest NeoForge version for the specified NeoForge major version</returns>
        /// <exception cref="WebException">Cannot retrieve NeoForge versions data</exception>
        public static string RetrieveNeoForgeLatestVersionData(string neoForgeVersion)
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(string.Concat(neoForgeLatestVersionBaseUrl, neoForgeVersion));

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<McNeoForgeVersionJsonEntry>(jsonRawContent).Version;

                throw new WebException("Cannot retrieve available NeoForge versions data. Please check your Internet connection.");
            }
        }
    }
}
