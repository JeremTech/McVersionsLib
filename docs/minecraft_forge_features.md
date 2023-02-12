# Minecraft Forge features

Find all features provided by McVersionsLib to retrieve **Minecraft Forge** modding API data.

## Retrieve all supported Minecraft versions
To retrieve all supported Minecraft versions, you can call `GetAllSupportedMinecraftVersion` function from the `McForgeVersions` class.
This function returns all supported Minecraft versions by Minecraft Forge.

```c#
List<string> supportedMcVersions = McForgeVersions.GetAllSupportedMinecraftVersion();
```

#### Arguments :
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"1.19.3", "1.18.2"`

#### Exception :
`WebException` : Cannot retrieve Forge versions data

## Retrieve all Minecraft Forge versions for a specific Minecraft version
To retrieve all Minecraft Forge versions for a specific Minecraft version, you can call `GetAllMinecraftForgeVersions` function from the `McForgeVersions` class.
This function returns all available Minecraft Forge versions for the targetted Minecraft version.

```c#
List<string> availableMcForgeVersions = McForgeVersions.GetAllMinecraftForgeVersions("1.19.3");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version<br/>
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Example : `"1.19.2-43.1.47"`

#### Exceptions :
`WebException` : Cannot retrieve Forge versions data<br/>
`VersionNotFoundException` : No available Minecraft Forge version for the taregetted Minecraft version

## Retrieve recommended Minecraft Forge version for a specific Minecraft version
To retrieve recommended Minecraft Forge version for a specific Minecraft version, you can call `GetRecommendedMinecraftForgeVersion` function from the `McForgeVersions` class.
This function returns recommended Minecraft Forge version for the targetted Minecraft version.

```c#
string recommendedMcForgeVersions = McForgeVersions.GetRecommendedMinecraftForgeVersion("1.19.3");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version<br/>
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`string` : Recommended Minecraft Forge version (`string.Empty` if not found)<br/>
Example : `"1.19.2-43.1.47"`

#### Exceptions :
`WebException` : Cannot retrieve Forge versions data<br/>


## Retrieve latest Minecraft Forge version for a specific Minecraft version
To retrieve latest Minecraft Forge version for a specific Minecraft version, you can call `GetLatestMinecraftForgeVersion` function from the `McForgeVersions` class.
This function returns latest Minecraft Forge version for the targetted Minecraft version.

```c#
string latestMcForgeVersions = McForgeVersions.GetLatestMinecraftForgeVersion("1.19.3");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version<br/>
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`string` : Latest Minecraft Forge version (`string.Empty` if not found)<br/>
Example : `"1.19.2-43.1.47"`

#### Exceptions :
`WebException` : Cannot retrieve Forge versions data<br/>

## Build Minecraft Forge installer direct Download link
If you want the direct download link for a Minecraft Forge installer, you can call `BuildMinecraftForgeInstallerLink` function from the `McForgeUtils` class.

```c#
string installerDownloadLink = McForgeUtils.BuildMinecraftForgeInstallerLink("1.19.2-43.1.47");
```

#### Arguments :
`mcforgeVersion` : `string`, Minecraft Forge version

#### Result :
`string` : Direct download link for the wanted Minecraft Forge installer<br/>
Example : `"https://files.minecraftforge.net/maven/net/minecraftforge/forge/1.19.2-43.1.47/forge-1.19.2-43.1.47-installer.jar"`

## Build Minecraft Forge MDK direct Download link
If you want the direct download link for a Minecraft Forge MDK, you can call `BuildMinecraftForgeMDKDownloadLink` function from the `McForgeUtils` class.

```c#
string mdkDownloadLink = McForgeUtils.BuildMinecraftForgeMDKDownloadLink("1.19.2-43.1.47");
```

#### Arguments :
`mcforgeVersion` : `string`, Minecraft Forge version

#### Result :
`string` : Direct download link for the wanted Minecraft Forge MDK<br/>
Example : `"https://files.minecraftforge.net/maven/net/minecraftforge/forge/1.19.2-43.1.47/forge-1.19.2-43.1.47-mdk.zip"`
