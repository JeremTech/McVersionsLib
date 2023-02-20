using System.Net;
using Newtonsoft.Json;

namespace McVersionsLib.Minecraft
{
    /// <summary>
    /// Minecraft data collector class
    /// </summary>
    public static class McDataCollector
    {
        /// <summary>
        /// URL to Minecraft versions manifest JSON
        /// </summary>
        private static readonly string manifestUrl = "https://piston-meta.mojang.com/mc/game/version_manifest_v2.json";

        /// <summary>
        /// Retrieve all available Minecraft versions from Mojang Studios servers
        /// </summary>
        /// <returns>Deserialized Minecraft versions list</returns>
        /// <exception cref="WebException">Cannot retrieve Minecraft versions data</exception>
        public static McVersionManifestJson RetrieveAllAvailableMinecraftVersionsData()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonRawContent = webClient.DownloadString(manifestUrl);

                if (!string.IsNullOrEmpty(jsonRawContent))
                    return JsonConvert.DeserializeObject<McVersionManifestJson>(jsonRawContent);

                throw new WebException("Cannot retrieve available Minecraft versions data. Please check your Internet connection.");
            }
        }
    }
}
