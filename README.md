# MT Business Framework

A lightweight framework for building modern business applications with Blazor and .NET.

---

## Philosophy

MT Business Framework is built around a few simple principles:

- Prefer .NET over custom code.
- Prefer simplicity over abstraction.
- Prefer composition over inheritance.
- Prefer services over helpers.
- Prefer proven solutions over fashionable patterns.

---

## Features

- Argument validation (Guard)
- Result pattern
- Business exceptions
- SQLite support
- Automatic database initialization
- File system services
- Backup services
- Settings services

---

## Getting Started

```csharp
builder.Services
    .AddMTBusinessFramework()
    .AddSqliteDatabase<AppDbContext>(
        ApplicationDefaults.ConnectionString);

var app = builder.Build();

app.UseMTBusinessFramework();

app.Run();
```

---

## Project Goals

- Simple
- Readable
- Maintainable
- Business oriented