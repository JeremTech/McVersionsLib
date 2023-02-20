using System.Collections.Generic;
using Newtonsoft.Json;

namespace McVersionsLib.Minecraft
{
    public class McVersionManifestJson
    {
        /// <summary>
        /// Latest release and snapshot version
        /// </summary>
        [JsonProperty("latest")]
        public McVersionManifestJsonLatestEntry LatestVersionsIds { get; set; }

        /// <summary>
        /// All Minecraft versions data
        /// </summary>
        [JsonProperty("versions")]
        public List<McVersionsManifestJsonVersionEntry> AllVersionsData { get; set; }
    }
}
