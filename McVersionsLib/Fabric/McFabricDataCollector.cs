using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

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

        /// <summary>
        /// Retrieve Fabric game versions data from the official project's website
        /// </summary>
        /// <returns>List of Fabric's supported game versions data</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric game versions data</exception>
        public static List<McFabricGameVersionJsonEntry> RetrieveFabricGameVersionsData()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(gameVersionsUrl);

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<List<McFabricGameVersionJsonEntry>>(jsonRawContent);

                throw new WebException("Cannot retrieve available Fabric game versions data. Please check your Internet connection.");
            }
        }

        /// <summary>
        /// Retrieve Fabric loader versions data from the official project's website
        /// </summary>
        /// <returns>List of Fabric's loader versions data</returns>
        /// <exception cref="WebException">Cannot retrieve Fabric loader versions data</exception>
        public static List<McFabricLoaderVersionJsonEntry> RetrieveFabricLoaderVersionsData()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(loaderVersionsUrl);

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<List<McFabricLoaderVersionJsonEntry>>(jsonRawContent);

                throw new WebException("Cannot retrieve available Fabric loader versions data. Please check your Internet connection.");
            }
        }

        /// <summary>
        /// Retrieve Fabric versions details about one Minecraft version
        /// </summary>
        /// <param name="mcVersion">Targeted Minecraft version</param>
        /// <returns>List of Fabric's loader </returns>
        /// <exception cref="WebException"></exception>
        public static List<McFabricVersionDetailJsonEntry> RetrieveFabricVersionsDetailsData(string mcVersion)
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(string.Concat(loaderVersionsUrl, mcVersion));

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<List<McFabricVersionDetailJsonEntry>>(jsonRawContent);

                throw new WebException("Cannot retrieve Fabric versions data. Please check your Internet connection.");
            }
        }
    }
}
