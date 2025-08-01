# CleanArchitectureRestApiTemplate

Template de API RESTful criada com ASP.NET Core 9, usando:

-  Entity Framework Core com Migrations
-  Injeção de Dependência
-  SOLID + Clean Architecture
-  Swagger integrado
-  Testes unitários com xUnit

## Como rodar

```bash
dotnet restore
dotnet ef database update
dotnet run --project ProductOrderAPI.Api
