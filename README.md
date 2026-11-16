# GeometryLibrary

Библиотека на C# для вычисления площади геометрических фигур. Разработана в рамках тестового задания Mindbox.

## Возможности

- Вычисление площади круга по радиусу.
- Вычисление площади треугольника по трём сторонам (формула Герона).
- Проверка треугольника на прямоугольность.
- Проверка корректности входных параметров.
- Поддержка расширения библиотеки новыми фигурами через интерфейс `IShape`.
- Модульные тесты с использованием xUnit.

## Технологии

- C# / .NET 10
- xUnit
- MS SQL Server (SQL-запрос)

## Пример использования

```csharp
using GeometryLibrary; 

IShape circle = Circle.CreateCircle(5);
IShape triangle = Triangle.CreateTriangle(3, 4, 5);

Console.WriteLine(circle.CalculateArea());
Console.WriteLine(triangle.CalculateArea());

Triangle rightTriangle = Triangle.CreateTriangle(3, 4, 5);
Console.WriteLine(rightTriangle.IsRightAngle());
```

## Запуск тестов

Из корневой папки решения выполните:

```bash
dotnet test
```

## SQL-задание

SQL-запрос находится в файле [`sql/query.sql`](sql/query.sql).

Он возвращает пары «Название продукта — Название категории», включая продукты, у которых нет категорий.