namespace McVersionsLib.Forge
{
    /// <summary>
    /// Usefull functions for Minecraft Forge
    /// </summary>
    public static class McForgeUtils
    {
        /// <summary>
        /// Build SDK download link for a Minecraft Forge version
        /// </summary>
        /// <param name="mcforgeVersion">Full Minecraft Forge version (eg: 1.19.2-43.1.47)</param>
        /// <returns>MDK download link for the targetted Minecraft Forge version</returns>
        public static string BuildMinecraftForgeMDKDownloadLink(string mcforgeVersion)
        {
            return string.Format("https://files.minecraftforge.net/maven/net/minecraftforge/forge/{0}/forge-{0}-mdk.zip", mcforgeVersion);
        }

        /// <summary>
        /// Build installer download link for a Minecraft Forge version
        /// </summary>
        /// <param name="mcforgeVersion">Full Minecraft Forge version (eg: 1.19.2-43.1.47)</param>
        /// <returns>Installer download link for the targetted Minecraft Forge version</returns>
        public static string BuildMinecraftForgeInstallerLink(string mcforgeVersion)
        {
            return string.Format("https://files.minecraftforge.net/maven/net/minecraftforge/forge/{0}/forge-{0}-installer.jar", mcforgeVersion);
        }
    }
}
