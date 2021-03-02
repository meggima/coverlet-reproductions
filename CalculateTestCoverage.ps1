Push-Location $PSScriptRoot
try {
    dotnet restore .\CoverletReproductions.sln
    dotnet build .\CoverletReproductions.sln --no-restore --configuration release
    dotnet test .\CoverletReproductions.sln --no-build --no-restore --configuration release --logger:trx -v minimal /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
    dotnet tool update -g dotnet-reportgenerator-globaltool
    reportgenerator "-reports:.\CoverletReproductions.Test\**\*.opencover.xml" "-targetdir:coveragereport" -reporttypes:HTMLInline

    . .\coveragereport\index.htm
}
finally {
    Pop-Location
}
