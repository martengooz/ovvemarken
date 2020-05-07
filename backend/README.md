## Installation

### Windows
[//]: # (Todo)

### Linux (Ubuntu/Debian)

Install ASP.NET Core
``` bash
# Register Microsoft key and feed
wget https://packages.microsoft.com/config/ubuntu/19.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

# Install the .NET Core SDK
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get install dotnet-sdk-3.1
```

Install [NuGet CLI tools](https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools)

```bash
# Install mono runtime
sudo apt-get update
sudo apt-get install mono-runtime

# Install NuGet CLI and install packages
sudo curl -o /usr/local/bin/nuget.exe https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mono /usr/local/bin/nuget.exe install
```

### VsCode Extensions
* `C#` - Includes syntax highlighting, tools for running and debugging C#.
* `NuGet Package Manager` - Can be used instead of NuGet CLI tools to install and add packages. 

## Configure
Settings related to webserver port can be found in `Properties/launchSettings.json`.

## Running 
Should start automatically when pressing `Ctrl+F5` (with debug) or `Ctrl+Shift+F5` (build without debug) in Visual Studio or VsCode.