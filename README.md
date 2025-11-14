**Wymagane narzędzia:**
- NET SDK	8.0.100
- PostgreSQL	16.10
- EF Core Tools	dotnet-ef
- Microsoft.EntityFrameworkCore	8.0.8
- Microsoft.EntityFrameworkCore.Design	8.0.8
- Microsoft.EntityFrameworkCore.Tools	8.0.6
- Npgsql.EntityFrameworkCore.PostgreSQL	8.0.4

**Konfiguracja bazy danych PostgreSQL:**
Utwórz bazę danych:
- _CREATE DATABASE todo_db;_

W pliku _backend/appsettings.json_ uzupełnij connection string:
- _"ConnectionStrings": { "DefaultConnection": "Host=localhost;Port=5432;Database=todo_db;Username=postgres;Password=YOUR_PASSWORD" }_
  
**Migracje bazy danych:**
Wejdź do katalogu backendu i zrób aktualizację bazy:
- _dotnet ef database update_

**Uruchomienie backendu:**
- _dotnet run_
  
_Pamiętaj, aby uruchomić backend, zanim uruchomisz frontend_
