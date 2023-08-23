# Azure App Config Service

Execute `create-app-config.azcli` to create an Azure App Configuration Service. Note the connection string and use it in the demos from folder `01-build-publish`.


Set the `UseAppConfig` to `true` and use Azure App Configuration in:

- .NET
- Azure Functions

## .NET

Run config-api container and override values from appsettings.json with environment variables:

```bash
docker run -d -p 5051:80 -e "App:UseAppConfig=true" -e "App:AppConfigConnection=$configCon" config-api
```

Browse to `http://localhost:5051/settings`. The title should be `Config Api Dev` as this value was set in the `development` environment in Azure App Configuration Service.    

## Azure Function

Add the following code to `Program.cs` in the Azure Function project in the current folder:

```csharp
.ConfigureAppConfiguration(builder =>
{
    string cs = Environment.GetEnvironmentVariable("AppConfigConnection");
    builder.AddAzureAppConfiguration(cs);
})
```

The result should look like this:

```csharp
var host = new HostBuilder()
    .ConfigureAppConfiguration(builder =>
    {
        string cs = Environment.GetEnvironmentVariable("AppConfigConnection");
        builder.AddAzureAppConfiguration(cs);
    })
    .ConfigureFunctionsWorkerDefaults()
    .Build();

host.Run();
```

Notice that local.settings.json contains a setting `App:Funcapp` which will be overriden by the value in Azure App Configuration Service. To test it locally you would use the following Url:

```bash
http://localhost:7071/api/getEnvVariable?paramName=App:Funcapp
```

Re-build the container and assign it the `appcfg` tag:

```bash
docker build --rm -f dockerfile -t config-func:appcfg .
```

Run the container and override the `AppConfigConnection` environment variable with the connection string from Azure App Configuration Service:

```bash
docker run -d -p 5053:80 -e "AppConfigConnection=$configCon" config-func:appcfg
```

Test the function using:

```bash
http://localhost:5053/api/getEnvVariable?paramName=App:Funcapp
```