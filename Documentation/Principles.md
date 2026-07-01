# MT Business Framework Principles

## 1. Simplicity First

Prefer the simplest solution that solves the problem.

---

## 2. Core Is Independent

Core must not reference Blazor, EF Core or ASP.NET.

---

## 3. Infrastructure Is Hidden

Business code should not know implementation details.

---

## 4. Avoid Duplication

If code is duplicated across multiple projects, move it into the framework.

---

## 5. Clean Program.cs

Program.cs should only configure the application.