Nuget
1- Será necessário acessar o diretório de seu arquivo .csproj através do comando cd. Por exemplo, cd caminho/do/projeto/.
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.5
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.5
dotnet add package MySql.Data.EntityFrameworkCore --version 5.0.3

dotnet add package Microsoft.AspNetCore.Components --version 6.0.5
dotnet add package Microsoft.Extensions.DependencyInjection --version 6.0.0
dotnet add package Microsoft.Extensions.Hosting --version 6.0.1
dotnet add package Microsoft.Extensions.Configuration --version 6.0.1

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Pomelo.EntityFrameworkCore.MySql

-- migration
dotnet tool install --global dotnet-ef
dotnet ef migrations add FilmeMigration
dotnet ef database update

-- automapper
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 11.0.0