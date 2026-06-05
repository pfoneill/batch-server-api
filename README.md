# batch-server-api exploration

References:

* [FactoryTalk Batch Server API `batch-rm003.pdf`](https://literature.rockwellautomation.com/idc/groups/literature/documents/rm/batch-rm003_-en-d.pdf)

## Notes

BatchServer and BatchRemote

* `BatchServer` is a local system based object used to communicate with a BatchServer running locally on the same system.
* `BatchRemote` provides the same functionality as `BatchServer` but can be run from a remotely connected system.

## Getting started

Using `pixi` to manage dotnet-sdk. Therefore dotnet sdk install is not required system wide. However a compatible .NET version is required to be installed on the system.

Install the .NET SDK system wide, first download from the Microsoft website.

```pwsh
# check to see if dotnet is installed
dotnet --version
```

Install Visual Studio Build Tools - https://visualstudio.microsoft.com/downloads/#remote-tools-for-visual-studio-2022
Visual Studio Build Tools are used for creating interop assembleys. Install the .NET Framework and .NET desktop build tools under the workloads tab.

[Configure VS Code](https://code.visualstudio.com/docs/cpp/config-msvc).

* C# Dev Kit
* Visual Basic

```pwsh
# create a new VB console project
dotnet new console -lang "VB"
```

### Generate the Interop Assembly from Type Libary

Generate the interop assembly used here from the `Batchserver.tlb`

```pwsh
# run these commands in the VS developer command prompt
tlbimp "C:\Program Files (x86)\Rockwell Software\Batch\Bin\batchsvr.tlb" /out:lib\Interop.batchsvr.dll /namespace:batchsvr.Interop
tlbimp "C:\Program Files (x86)\Rockwell Software\Batch\Bin\AreaModelConvert.tlb" /out:lib\Interop.AreaModelConvert.dll /namespace:AreaModelConvert.Interop
```
