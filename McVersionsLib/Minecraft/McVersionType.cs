﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace McVersionsLib.Minecraft
{
    /// <summary>
    /// Minecraft version type enumeration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum McVersionType
    {
        /// <summary>
        /// Snapshot
        /// </summary>
        [EnumMember(Value = "snapshot")]
        Snapshot = 'S',
        /// <summary>
        /// Release
        /// </summary>
        [EnumMember(Value = "release")]
        Release = 'R',
        /// <summary>
        /// Old beta
        /// </summary>
        [EnumMember(Value = "old_beta")]
        Beta = 'B',
        /// <summary>
        /// Old alpha
        /// </summary>
        [EnumMember(Value = "old_alpha")]
        Alpha = 'A'
    }
}
