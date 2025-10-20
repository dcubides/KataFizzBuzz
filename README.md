# 🧩 Katas TDD - FizzBuzz

Este proyecto es una **kata de programación** para practicar los fundamentos de **TDD (Test Driven Development)** en C#.

El objetivo es implementar el clásico problema **FizzBuzz**, aplicando el ciclo **Rojo 🟥 → Verde 🟩 → Azul 🟦 (Refactor)**, manteniendo siempre las pruebas automáticas como guía del desarrollo.

---

## 🚀 Objetivo de la Kata

Implementar una función `FizzBuzz.Calcular(int numero)` que:
- Devuelva una lista de strings con los valores desde `0` hasta `numero`.
- Para cada número:
    - Si es múltiplo de **3**, devolver `"Fizz"`.
    - Si es múltiplo de **5**, devolver `"Buzz"`.
    - Si es múltiplo de **3 y 5**, devolver `"FizzBuzz"`.
    - En cualquier otro caso, devolver el número como texto (`"7"`, `"11"`, etc.).

Ejemplo:
```csharp
FizzBuzz.Calcular(5) // → ["0", "1", "2", "Fizz", "4", "Buzz"]