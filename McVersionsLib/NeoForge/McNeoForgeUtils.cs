using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            string secondaryNumber = mcVersionSplit.ElementAtOrDefault(2);
            if (string.IsNullOrWhiteSpace(secondaryNumber))
                secondaryNumber = "0";

            return string.Join(".", mcVersionSplit.ElementAtOrDefault(1), secondaryNumber);
        }
    }
}
