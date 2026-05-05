using System;
using System.Collections.Generic;
using System.Linq;

namespace McVersionsLib.NeoForge
{
    /// <summary>
    /// Usefull functions for NeoForge
    /// </summary>
    public static class McNeoForgeUtils
    {
        /// <summary>
        /// Get NeoForge forge major version for a specific Minecraft version
        /// </summary>
        /// <param name="mcVersion">Targeted Minecraft version</param>
        /// <returns>NeoForge major version number</returns>
        public static string GetNeoForgeVersionFromMinecraftVersion(string mcVersion)
        {
            List<string> mcVersionSplit = mcVersion.Split('.').ToList();

            // For new Minecraft versioning system, NeoForge version is the same as Minecraft version
            if (!string.Equals(mcVersionSplit.ElementAtOrDefault(0), "1", StringComparison.InvariantCultureIgnoreCase))
                return mcVersion;

            // For old Minecraft versioning system, NeoForge version is the minor and build Minecraft version numbers
            // Example : for Minecraft 1.20.4, NeoForge version is 20.4
            string secondaryNumber = mcVersionSplit.ElementAtOrDefault(2);
            if (string.IsNullOrWhiteSpace(secondaryNumber))
                secondaryNumber = "0";

            return string.Join(".", mcVersionSplit.ElementAtOrDefault(1), secondaryNumber);
        }
    }
}
