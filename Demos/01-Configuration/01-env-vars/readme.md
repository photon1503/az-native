# Working with Env Vars

[Share environment variables between Windows and WSL with WSLENV](https://docs.microsoft.com/en-us/windows/wsl/filesystems#share-environment-variables-between-windows-and-wsl-with-wslenv)

## Demos

Change Default Terminal in Visual Studio Code settings:

```
"terminal.integrated.defaultProfile.windows": "Command Prompt",
```

Listing env vars in Windows:

```cmd
SET
```

>Note: To refresh Windows env vars install [Chocolatey](https://chocolatey.org/install) and run `refreshenv` to avoid closing and re-opening the `cmd`

Listing env vars in bash:

```bash
printenv
```

![vars](_images/vars.png)

Sharing Windows Env vars to WSL:

```bash
set abc=345
set WSLENV=abc/u
```