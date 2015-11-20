SET version="v1.3"

"..\packages\ilmerge.2.14.1208\tools\ILMerge.exe" "..\src\BatchGuy.App\bin\Release\BatchGuy.App.exe" "..\packages\System.Linq.Dynamic.1.0.4\lib\net40\System.Linq.Dynamic.dll" /out:"BatchGuy-%version%-win64.exe"  /target:winexe /targetplatform:v4 /ndebug