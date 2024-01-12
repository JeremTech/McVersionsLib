using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace McVersionsLib.NeoForge
{
    public class McNeoForgeVersionJsonEntry
    {
        /// <summary>
        /// Snapshot status
        /// </summary>
        [JsonProperty("isSnapshot")]
        public bool IsSnapshot { get; set; }

        /// <summary>
        /// NeoForge version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
