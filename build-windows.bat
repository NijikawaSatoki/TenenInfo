rem This builds on Windows, regardless of if you're running an x86 or x86_64 (also known as x64) architecture
start dotnet publish --nologo --configuration Release --self-contained true --runtime win-x86 -p:PublishSingleFile=True -o rel\
