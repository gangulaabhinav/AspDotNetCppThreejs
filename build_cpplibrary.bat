echo Building CppLibrary.vcxproj to the location %DEPLOYMENT_TEMP%
IF DEFINED DEPLOYMENT_TEMP (
    msbuild CppLibrary\CppLibrary.vcxproj /p:configuration=Release /p:platform=win32 /p:OutDir="%DEPLOYMENT_TEMP%"
)
