using Newtonsoft.Json;

namespace McVersionsLib.Minecraft
{
    public class McVersionManifestJsonLatestEntry
    {
        /// <summary>
        /// Latest Minecraft release version
        /// </summary>
        [JsonProperty("release")]
        public string LatestRelease { get; set; }

        /// <summary>
        /// Latest Minecraft snapshot version
        /// </summary>
        [JsonProperty("snapshot")]
        public string LatestSnapshot { get; set; }
    }
}
