**ToDo API — ASP.NET Core 8 Web API**

Backend aplikacji ToDo stworzony w ASP.NET Core 8, z wykorzystaniem Entity Framework Core oraz PostgreSQL.

**Technologie**
- ASP.NET Core 8
- Entity Framework Core 8
- PostgreSQL 16
- Npgsql.EntityFrameworkCore.PostgreSQL
- EF Core Migrations
- REST API

**Wymagane narzędzia**
- .NET SDK	8.0.100
- PostgreSQL	16.10
- Entity Framework Core Tools	dotnet-ef
- Microsoft.EntityFrameworkCore	8.0.8
- Microsoft.EntityFrameworkCore.Design	8.0.8
- Microsoft.EntityFrameworkCore.Tools	8.0.6
- Npgsql.EntityFrameworkCore.PostgreSQL	8.0.4

Zainstaluj EF Core CLI:
- dotnet tool install --global dotnet-ef

Zainstaluj pakiety NuGet:
- dotnet add package Microsoft.EntityFrameworkCore --version 8.0.8
- dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.8
- dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.6
- dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.4

**Konfiguracja bazy danych**
Utwórz bazę:
- CREATE DATABASE todo_db;

W pliku _appsettings.json_ ustaw connection string:
"ConnectionStrings": { "DefaultConnection": "Host=localhost;Port=5432;Database=todo_db;Username=postgres;Password=YOUR_PASSWORD" }

**Migracje EF Core**
Przejdź do folderu backen i wykonaj migracje:
- dotnet ef database update

**Uruchomienie API**
- dotnet run

_Pamiętaj, aby uruchomić backend, zanim uruchomisz frontend_

**Dostępne endpointy**
- GET	/api/todo	Zwraca wszystkie zadania, posortowane po Id ASC
- GET	/api/todo/{id}	Zwraca jedno zadanie po ID
- POST	/api/todo	Tworzy nowe zadanie
- PUT	/api/todo/{id}	Aktualizuje istniejące zadanie

**Schemat modeli**

TodoItem:
- Id
- Title 
- Description 
- IsDone 
- CreatedAt

CreateTodoDto oraz UpdateTodoDto:
- Title
- Description
- IsDone
