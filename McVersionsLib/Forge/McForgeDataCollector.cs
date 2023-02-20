using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace McVersionsLib.Forge
{
    /// <summary>
    /// Minecraft Forge data collector class
    /// </summary>
    public static class McForgeDataCollector
    {
        /// <summary>
        /// URL to Forge's promoted versions JSON
        /// </summary>
        private static readonly string promotionsUrl = "https://files.minecraftforge.net/maven/net/minecraftforge/forge/promotions_slim.json";

        /// <summary>
        /// URL to all Forge's versions JSON
        /// </summary>
        private static readonly string versionsUrl = "https://files.minecraftforge.net/maven/net/minecraftforge/forge/maven-metadata.json";

        /// <summary>
        /// Retrieve all available Minecraft Forge versions from the official project's website
        /// </summary>
        /// <returns>Deserialized Forge versions json with minecraft version as key (<c>string</c>), and list of all minecraft forge version for this minecraft version (List of <c>string</c>)</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        public static Dictionary<string, List<string>> RetrieveAllAvailableMinecraftForgeVersionsData()
        {
            using(WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(versionsUrl);

                if(!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonRawContent);

                throw new WebException("Cannot retrieve available Forge versions data. Please check your Internet connection.");
            }
        }

        /// <summary>
        /// Retrieve promoted Minecraft Forge versions from the official project's website
        /// </summary>
        /// <returns>Deserialized Forge promoted versions json</returns>
        /// <exception cref="WebException">Cannot retrieve Forge versions data</exception>
        public static McForgePromotionsJson RetrievePromotedMinecraftForgeVersionsData()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(promotionsUrl);

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<McForgePromotionsJson>(jsonRawContent);

                throw new WebException("Cannot retrieve promoted Forge versions data. Please check your Internet connection.");
            }
        }
    }
}
