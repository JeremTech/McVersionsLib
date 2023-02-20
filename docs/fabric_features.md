# Fabric features

Find all features provided by McVersionsLib to retrieve **Fabric** modding API data.

## Retrieve all supported Minecraft versions
To retrieve all supported Minecraft versions, you can call `GetAllSupportedMinecraftVersions` function from the `McFabricVersions` class.
This function returns all supported Minecraft versions by Fabric.

```c#
List<string> supportedMcVersions = McFabricVersions.GetAllSupportedMinecraftVersions();
```

#### Arguments :
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"1.19.3", "23w05a"`

#### Exception :
`WebException` : Cannot retrieve Fabric versions data

## Retrieve all supported Minecraft stable versions
To retrieve all supported Minecraft stable versions (mainly officials releases), you can call `GetAllSupportedStableMinecraftVersions` function from the `McFabricVersions` class.
This function returns all supported Minecraft stable versions by Fabric.

```c#
List<string> supportedMcVersions = McFabricVersions.GetAllSupportedStableMinecraftVersions();
```

#### Arguments :
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"1.19.3", "1.18.2"`

#### Exception :
`WebException` : Cannot retrieve Fabric versions data

## Retrieve all supported Minecraft unstable versions
To retrieve all supported Minecraft unstable versions (mainly snapshots), you can call `GetAllSupportedUnstableMinecraftVersions` function from the `McFabricVersions` class.
This function returns all supported Minecraft unstable versions by Fabric.

```c#
List<string> supportedMcVersions = McFabricVersions.GetAllSupportedUnstableMinecraftVersions();
```

#### Arguments :
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"1.19.3", "1.18.2"`

#### Exception :
`WebException` : Cannot retrieve Fabric versions data

## Retrieve all Fabric's loader versions
To retrieve all Fabric's loader versions, you can call `GetAllLoaderVersions` function from the `McFabricVersions` class.
This function returns all Fabric's loader versions.

```c#
List<string> loaderVersions = McFabricVersions.GetAllLoaderVersions();
```

#### Result :
`List<string>` : List of strings<br/>
Examples : `"0.14.14", "0.13.1"`

#### Exception :
`WebException` : Cannot retrieve Fabric versions data

## Retrieve all Fabric's loader versions for a specific Minecraft version
To retrieve all Fabric's loader versions for a specific Minecraft version, you can call `GetAllLoaderVersions` function from the `McFabricVersions` class.
This function returns the C# representation of a Fabric version JSON.

```c#
List<string> loaderVersions = McFabricVersions.GetAllLoaderVersions("1.19.3");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version

#### Result :
`List<string>` : List of strings<br/>
Examples : `"0.14.14", "0.13.1"`

#### Exception :
`WebException` : Cannot retrieve Fabric versions data<br/>
`VersionNotFoundException` : No available Fabric version for the targetted Minecraft version

## Retrieve loader and mappings details for a specific Minecraft and loader version
To retrieve loader and mappings details for a specific Minecraft and loader version, you can call `GetLoaderAndMappingsDetails` function from the `McFabricVersions` class with one argument : the targetted Minecraft version.
This function returns all Fabric's loader versions for the targetted Minecraft version.

```c#
McFabricVersionDetailJsonEntry loaderMappingsDetails = McFabricVersions.GetLoaderAndMappingsDetails("1.19.3", "0.14.14");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version<br/>
`targetedLoaderVersion` : `string`, targetted Fabric loader version

#### Result :
`McFabricVersionDetailJsonEntry` : C# representation of a Fabric version JSON with all details

#### Exception :
`WebException` : Cannot retrieve Fabric versions data<br/>
`VersionNotFoundException` : No available Fabric version for the targetted Minecraft version<br/>
`VersionNotFoundException` : The targeted loader version for the targeted Minecraft was not found
