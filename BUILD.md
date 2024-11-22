# Build instructions

## `dotnet build` (Recommended)

To build this project, you do need to have the SDK (software development kit) for .NET (`dotnet`) installed on your system.
Search for the relevant package(s) via your package manager (Linux) or [grab it directly from Microsoft](https://dotnet.microsoft.com/en-us/download) (Windows).

Got `dotnet` installed?
Good.
Let's continue.
In a terminal shell (`cmd.exe` if on Windows, your usual terminal if on Linux), ensure that your current directory is the root of the project folder and run:

If on Linux:
```
dotnet publish --nologo --configuration Release --self-contained true --runtime linux-x86 -p:PublishSingleFile=True -o ./rel/TenenInfo/
```

If on Windows (via `cmd.exe`):
```
dotnet publish --nologo --configuration Release --self-contained true --runtime win-x86 -p:PublishSingleFile=True -o rel\TenenInfo\
```

If that seems overly verbose, it's `dotnet`.
What we're you expecting?
Conciseness?
It's Microsoft, and they hate conciseness.

Then run from the command line your executable.

Windows:
```
rel\TenenInfo\TenenInfo.exe
```

Linux:
```
./rel/TenenInfo/TenenInfo
```