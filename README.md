# Source Link Demo
#.gitignore file created by `dotnet new gitignore`

DemoSourceLink test

#### Enable Source Link Symbol Server
This is used for step into 3rd party library, e.g. it will download the .pdb file from Nuget.org.
![Enable Source Link symbol](https://github.com/bourne-xian/Demo/blob/main/Img/TurnOn%20SourceLink.png)

Disable Just My Code

![Disable Just My Code](https://github.com/bourne-xian/Demo/blob/main/Img/Disable%20Just%20My%20Code.png)

Then we could step into 3rd lib: Behind the scenes, it download the source file from source code location (e.g. Github, Azure DevOps) .



Reference:

[Set symbol (.pdb) and source files in the debugger - Visual Studio (Windows) | Microsoft Docs](https://docs.microsoft.com/en-us/visualstudio/debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger?view=vs-2019#configure-symbol-locations-and-loading-options)

[Improving Debug-time Productivity with Source Link | .NET Blog](https://devblogs.microsoft.com/dotnet/improving-debug-time-productivity-with-source-link/)





#### Build Nuget Package that enabled Symbol Link

Edit csproj to build symbol package. The symbol package has extension with snupkg and it contains the symbol file (.pdb). So we could reduce the size of nupkg package which contains dll only. And source code is not embed into .pdb file, it's fetch from source control like Github or Azure Repos

![csproj file]([Demo/Update csproj.png at main · bourne-xian/Demo (github.com)](https://github.com/bourne-xian/Demo/blob/main/Img/Update csproj.png))

Publish the nuget to MyGet (it will upload the snupkg to symbol feed if it's in the same directory)  Another option is publish to Azure Artifacts.

Then we could debug just like we did for 3rd library.



Reference:

[Using Source Link in .NET projects](https://github.com/dotnet/sourcelink/blob/main/README.md#using-source-link-in-net-projects)

[Symbols (myget.org)](https://docs.myget.org/docs/reference/symbols)

[Alternatives -- Decompiled Source](https://devblogs.microsoft.com/visualstudio/decompilation-of-c-code-made-easy-with-visual-studio/)
