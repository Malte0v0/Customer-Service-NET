# CustomerService (ASP.NET Core)

Det här är en omskrivning av Customer-tjänsten från kursen Java Backend 2 till ASP.NET Core.

Målet med omskrivningen är att lära mig grunderna i både C# och .NET.

## Status

- [x] Controller + service med in-memory lista
- [x] PUT + validering
- [ ] EF Core + MariaDB databas
- [ ] Egna exceptions + global felhantering
- [ ] Tester

## Endpoints

`GET /api/customers` Hämtar alla kunder, svarar 200

`GET /api/customers/{id}` Hämtar en kund, svarar 200 / 404

`POST /api/customers` Skapa en kund, svarar 201

`DELETE /api/customers/{id}` Ta bort en kund, svarar 204 / 404
