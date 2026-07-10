# ADR-0001 – Design Principles

## Status

Accepted

## Context

MT Business Framework is intended to be a lightweight framework for building
business applications with Blazor and .NET.

The goal is not to replace .NET, but to complement it with carefully selected
building blocks that have proven useful in real-world projects.

---

## Decisions

### 1. Prefer .NET over custom code

Always use the .NET implementation when it already solves the problem well.

Examples:

- TimeProvider
- Dependency Injection
- Entity Framework Core

---

### 2. Prefer simplicity over abstraction

New abstractions are introduced only after repeated real-world usage.

---

### 3. Prefer composition over inheritance

Inheritance is used only when it significantly reduces duplication.

---

### 4. Prefer services over helper classes

Framework functionality is exposed through services registered with DI.

---

### 5. Every public class has a single responsibility

Each class should have one clear reason to change.

---

### 6. Infrastructure throws exceptions

Infrastructure failures are exceptional.

Business validation returns Result.

---

### 7. Framework grows from real applications

Every feature must originate from an actual business need.