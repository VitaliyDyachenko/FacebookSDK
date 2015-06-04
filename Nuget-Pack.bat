@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)

set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)

del  /F /Q build\*.*
 
%nuget% pack "src\FacebookSDK.csproj" -OutputDirectory "build" -Build -IncludeReferencedProjects -Symbols -Properties Configuration="%config%"

