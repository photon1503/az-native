# Azure App Config Service

Execute `create-app-config.azcli` to create an Azure App Configuration Service. Note the connection string and use it in the demos from folder `01-build-publish`.


Set the `UseAppConfig` to `true` and use Azure App Configuration in:

- .NET
- Angular
- Azure Functions

## .NET

Set `App:UseAppConfig` to `true` in `appsettings.json` and update `App:AppConfigConnection`

## Azure Function

Set the value of `AppConfigConnection` and add the following code to Program.cs:

```csharp
.ConfigureAppConfiguration(builder =>
{
    string cs = Environment.GetEnvironmentVariable("AppConfigConnection");
    builder.AddAzureAppConfiguration(cs);
})
```