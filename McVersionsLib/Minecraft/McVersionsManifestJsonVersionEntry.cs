using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace McVersionsLib.Minecraft
{
    public class McVersionsManifestJsonVersionEntry
    {
        /// <summary>
        /// Game version
        /// </summary>
        [JsonProperty("id")]
        public string Version { get; set; }

        /// <summary>
        /// Version type
        /// </summary>
        [JsonProperty("type")]
        public McVersionType VersionType { get; set; }

        /// <summary>
        /// Last manifest file update
        /// </summary>
        [JsonProperty("time")]
        public DateTime ManifestLastUpdateDate { get; set; }

        /// <summary>
        /// Release date
        /// </summary>
        [JsonProperty("releaseTime")]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// SHA1 hash
        /// </summary>
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        /// <summary>
        /// Compliance level<br/>
        /// If 0, the launcher warns the user about this version not being recent enough to support the latest player safety features. Its value is 1 otherwise.
        /// </summary>
        [JsonProperty("complianceLevel")]
        public int ComplianceLevel { get; set; }
    }
}
