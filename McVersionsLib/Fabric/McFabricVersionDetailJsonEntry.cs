﻿using Newtonsoft.Json;

namespace McVersionsLib.Fabric
{
    public class McFabricVersionDetailJsonEntry
    {
        /// <summary>
        /// Loader informations
        /// </summary>
        [JsonProperty("loader")]
        public McFabricLoaderVersionJsonEntry LoaderData { get; set; }

        /// <summary>
        /// Mappings informations
        /// </summary>
        [JsonProperty("mappings")]
        public McFabricMappingsVersionJsonEntry MappingsData { get; set; }
    }
}
