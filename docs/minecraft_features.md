# Minecraft features

Find all features provided by McVersionsLib to retrieve **Minecraft : Java Edition** data.

## Retrieve all available Minecraft versions
To retrieve all available versions, including releases, snapshot, betas and alphas, you can call `GetAllAvailableMinecraftVersions` function from the `McVersions` class.
This function returns all available versions ordered by release date descending.

```c#
List<string> availableVersions = McVersions.GetAllAvailableMinecraftVersions();
```

#### Arguments :
`forceRetrievingData` : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"1.18.2", "23w05a", "b1.7.3", "rd-132328"`

#### Exception :
`WebException` : Cannot retrieve Minecraft versions data.

## Retrieve only all available Minecraft release versions
To retrieve all available release versions only, you can call `GetAllAvailableMinecraftReleaseVersions` function from the `McVersions` class.
This function returns all available release versions ordered by release date descending.

```c#
List<string> availableReleaseVersions = McVersions.GetAllAvailableMinecraftReleaseVersions();
```

#### Arguments :
`forceRetrievingData` : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"1.19.2", "1.16.2"`

#### Exception :
`WebException` : Cannot retrieve Minecraft versions data.

## Retrieve only all available Minecraft snapshot versions
To retrieve all available snapshot versions, you can call `GetAllAvailableMinecraftSnapshotVersions` function from the `McVersions` class.
This function returns all available snapshot versions ordered by release date descending.

```c#
List<string> availableSnapshotVersions = McVersions.GetAllAvailableMinecraftSnapshotVersions();
```

#### Arguments :
`forceRetrievingData` : `bool`, force data retrieving even if data have been already retrieved with a previous function call (`false` by default).

#### Result :
`List<string>` : List of strings<br/>
Examples : `"23w05a", "19w45a"`

#### Exception :
`WebException` : Cannot retrieve Minecraft versions data.
