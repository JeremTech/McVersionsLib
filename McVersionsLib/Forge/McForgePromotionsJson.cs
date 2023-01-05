using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace McVersionsLib.Forge
{
    public class McForgePromotionsJson
    {
        /// <summary>
        /// Minecraft Forge project's homepage
        /// </summary>
        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Dictionnary of promoted Minecraft Forge versions
        /// </summary>
        /// <remarks>
        /// <c>Key</c> : Minecraft version with <c>-latest</c> or <c>-recommended</c> <br/>
        /// <c>Value</c> : Corresponding Minecraft Forge version
        /// </remarks>
        [JsonProperty("promos")]
        public Dictionary<string, string> Promos {get; set;}
    }
}
