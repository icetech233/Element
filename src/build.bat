@echo off

rem dotnet build ./Element.Core/Element.Core.csproj
rem 清空屏幕
cls


rem dotnet build ./Element.Core/Element.Core.csproj 

dotnet build ./Sample/Sample.csproj --debug
dotnet run --project Sample
