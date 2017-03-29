# mtapi
.Net Core api for MT sample

### Как запустить

1. Установить .Net Core (https://www.microsoft.com/net/core).
2. Клонировать репозиторий и выполнить в папке команды.
```
dotnet restore
dotnet run
```
Запуститься сервер по адресу http://localhost:5000.

### Описание Api

Адрес API: 

```
http://localhost:5000/api/
```

Запрос значений:

```
http://localhost:5000/api/values?searchfield={query}
```
