# Distributed Application Runtime - dapr

[Dapr - Visual Studio Code Extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-dapr)

## Setup

Install Dapr CLI

```
Set-ExecutionPolicy RemoteSigned -scope CurrentUser
powershell -Command "iwr -useb https://raw.githubusercontent.com/dapr/cli/master/install/install.ps1 | iex"
```

Initialize self-hosted Dapr

```
dapr init
```

Run Project

```
dapr run --app-id hello-world --app-port 5001 --dapr-http-port 5010 dotnet run
```

Show Dapr Dashboard

```
dapr dashboard
``` 

Examine `http://localhost:8080`