@echo Off

set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)

nuget push build\*.nupkg -Source https://www.myget.org/F/ixapp/api/v2/package