# batch-server-api exploration

References:

* FactoryTalk Batch Server API `batch-rm003.pdf`

## Notes

BatchServer and BatchRemote

* `BatchServer` is a local system based object used to communicate with a BatchServer running locally on the same system.
* `BatchRemote` provides the same functionality as `BatchServer` but can be run from a remotely connected system.

## Getting started

Using `pixi` to manage dotnet-sdk. Therefore dotnet sdk install is not required system wide.

Install the .NET SDK system wide, first download from the Microsoft website.

```pwsh
# check to see if dotnet is installed
dotnet --version
```

Set up VS Code extensions

* C# Dev Kit
* Visual Basic

```pwsh
# create a new VB console project
dotnet new console -lang "VB"
```
