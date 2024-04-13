dotnet restore
msbuild -t:pack InputInterceptor\InputInterceptor-PersonalFork.csproj -p:NuspecFile=..\Package.nuspec -p:Configuration=Release