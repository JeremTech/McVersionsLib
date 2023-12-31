using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace McVersionsLib.NeoForge
{
    public class McNeoForgeVersionsJson
    {
        /// <summary>
        /// Snapshot status
        /// </summary>
        [JsonProperty("isSnapshot")]
        public bool IsSnapshot { get; set; }

        /// <summary>
        /// List of NeoForge versions
        /// </summary>
        [JsonProperty("versions")]
        public List<string> Versions { get; set; }
    }
}
