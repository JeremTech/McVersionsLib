using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

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
        /// Retreive all available Minecraft Forge versions from the official project's website
        /// </summary>
        /// <returns>Deserialized Forge versions json</returns>
        /// <exception cref="WebException">Cannot retreive Forge versions data</exception>
        public static Dictionary<string, List<string>> RetrieveAllAvailableMinecraftForgeVersionsData()
        {
            using(WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(versionsUrl);

                if(!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonRawContent);

                throw new WebException("Cannot retreive available Forge versions data. Please check your Internet connection.");
            }
        }

        /// <summary>
        /// Retreive promoted Minecraft Forge versions from the official project's website
        /// </summary>
        /// <returns>Deserialized Forge promoted versions json</returns>
        /// <exception cref="WebException">Cannot retreive Forge versions data</exception>
        public static ForgePromotionsJson RetrievePromotedMinecraftForgeVersionsData()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(promotionsUrl);

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<ForgePromotionsJson>(jsonRawContent);

                throw new WebException("Cannot retreive promoted Forge versions data. Please check your Internet connection.");
            }
        }
    }
}
