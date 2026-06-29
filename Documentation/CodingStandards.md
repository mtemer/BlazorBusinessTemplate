# MT Business Framework

## Coding Standards

### General

- Use file-scoped namespaces.
- Use nullable reference types.
- Use implicit usings.
- One public type per file.
- Keep Program.cs free of business logic.

---

## Naming

Classes:
PascalCase

Interfaces:
IService

Methods:
PascalCase

Properties:
PascalCase

Private fields:
_fieldName

Constants:
PascalCase

---

## Services

- Services should be sealed unless inheritance is required.
- Services should return Result or Result<T>.
- Services should never return null.

---

## Documentation

Every public member should have XML documentation.

---

## Exceptions

Throw exceptions only for unexpected situations.

Business validation should return Result.Fail().

---

## Strings

Avoid magic strings.

Use ApplicationDefaults or Constants.

---

## Dependency Injection

All registrations must be placed in:

Extensions/
    ServiceCollectionExtensions.cs

---

## Middleware

All middleware registrations belong in:

Extensions/
    WebApplicationExtensions.cs

---

## Git

One logical feature = one commit.

Commit messages:

Foundation:
Core:
Feature:
Fix:
Refactor:
Docs:
