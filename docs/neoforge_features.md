# NeoForge features

Find all features provided by McVersionsLib to retrieve **NeoForge** modding API data.

## Retrieve all NeoForge versions
To retrieve all NeoForge versions, you can call `GetAllNeoForgeVersions` function from the `McNeoForgeVersions` class.
This function returns all available NeoForge versions.

```c#
List<string> availableNeoForgeVersions = McNeoForgeVersions.GetAllNeoForgeVersions();
```

#### Arguments :
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Example : `"20.2.45-beta"`

#### Exceptions :
`WebException` : Cannot retrieve NeoForge versions data<br/>
`VersionNotFoundException` : No available NeoForge version for the targetted Minecraft version


## Retrieve all NeoForge versions for a specific Minecraft version
To retrieve all NeoForge versions for a specific Minecraft version, you can call `GetAllNeoForgeVersions` function from the `McNeoForgeVersions` class.
This function returns all available NeoForge versions for the targetted Minecraft version.

```c#
List<string> availableNeoForgeVersions = McNeoForgeVersions.GetAllNeoForgeVersions("1.20.4");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version<br/>
`forceRetrievingData` *(optional)* : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Example : `"20.4.60-beta"`

#### Exceptions :
`WebException` : Cannot retrieve NeoForge versions data<br/>
`VersionNotFoundException` : No available NeoForge version for the targetted Minecraft version



## Retrieve latest NeoForge version for a specific Minecraft version
To retrieve latest NeoForge version for a specific Minecraft version, you can call `GetLatestNeoForgeVersion` function from the `McNeoForgeVersions` class.
This function returns latest NeoForge version for the targetted Minecraft version.

```c#
string latestNeoForgeVersions = McForgeVersions.GetLatestMinecraftForgeVersion("1.19.3");
```

#### Arguments :
`targetedMcVersion` : `string`, targetted Minecraft version<br/>

#### Result :
`string` : Latest NeoForge version for the targeted Minecraft version<br/>
Example : `"20.4.67-beta"`

#### Exceptions :
`WebException` : Cannot retrieve NeoForge versions data<br/>

## Get NeoForge version number from a Minecraft version
If you want to know the version number of NeoForge for a Minecraft version, you can call `GetNeoForgeVersionFromMinecraftVersion` function from the `McNeoForgeUtils` class. <br/>
This function doesn't check if a NeoForge version exists for the specified Minecraft version.

```c#
string neoForgeVersion = McNeoForgeUtils.GetNeoForgeVersionFromMinecraftVersion("1.20.4");
```

#### Arguments :
`mcVersion` : `string`, targeted Minecraft version

#### Result :
`string` : NeoForge version number for the specified Minecraft version<br/>
Example : `"20.4"`