using Newtonsoft.Json;

namespace McVersionsLib.Fabric
{
    public class McFabricGameVersionJsonEntry
    {
        /// <summary>
        /// Game version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Is game version stable ?
        /// </summary>
        [JsonProperty("stable")]
        public bool Stable { get; set; }
    }
}
