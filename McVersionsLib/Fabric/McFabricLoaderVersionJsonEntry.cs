using Newtonsoft.Json;

namespace McVersionsLib.Fabric
{
    public class McFabricLoaderVersionJsonEntry
    {
        /// <summary>
        /// Version separator
        /// </summary>
        [JsonProperty("separator")]
        public string Separator { get; set; }

        /// <summary>
        /// Build number
        /// </summary>
        [JsonProperty("build")]
        public int Build { get; set; }

        /// <summary>
        /// Maven reference
        /// </summary>
        [JsonProperty("maven")]
        public string Maven { get; set; }

        /// <summary>
        /// Loader version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Is loader version stable ?
        /// </summary>
        [JsonProperty("stable")]
        public bool Stable { get; set; }
    }
}
