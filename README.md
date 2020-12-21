# PROJECTMANAGER
A application for control projects.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download)
* [SqlServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in prompt command in project
2) Add your connection string in *"PROJECTManager.API/appsettings.Development.json"*
3) Execute migrations:
> Executing the "Update-Database" in Visual Studio Package Manager Console, or "ef database update" in command prompt in "PROJECTManager.API"
4) Run the *"PROJECTManager.API"*
## TECNOLOGIES USED
* Asp .Net Core 3.1
* Autofac
* Automapper
* C#
* Entity Framework Core
* Fluent Validator
* MediatR
* Swagger
## VERSIONS
* 1.0.0 - First Commit
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*
