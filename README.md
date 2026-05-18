Taller-3.2

# Taller 3.2 – Operaciones Binarias del Álgebra Relacional

## Descripción del Proyecto

El presente proyecto tiene como finalidad comprender y aplicar las operaciones binarias del álgebra relacional utilizando ADO.NET Entity Framework, LINQ y la base de datos Pubs.

Durante el desarrollo del taller se implementaron diferentes consultas relacionadas con las operaciones de unión, diferencia y producto cartesiano, permitiendo manipular información de forma declarativa mediante C# y Entity Framework.

La base de datos Pubs fue utilizada para trabajar con escenarios relacionados con editoriales, autores, libros, ventas y tiendas.

---

# Objetivos

## Objetivo General

Aplicar operaciones binarias del álgebra relacional utilizando Entity Framework y LINQ sobre la base de datos Pubs.

---

## Objetivos Específicos

- Implementar operaciones de unión entre conjuntos compatibles.
- Desarrollar consultas utilizando diferencia de conjuntos.
- Aplicar producto cartesiano entre entidades de la base de datos.
- Manipular datos mediante consultas declarativas utilizando LINQ.
- Comprender el comportamiento de las operaciones binarias dentro del modelo relacional.

---

# Tecnologías Utilizadas

- C#
- .NET
- ADO.NET Entity Framework
- LINQ
- SQL Server
- Base de datos Pubs
- Visual Studio
- GitHub

---

# Base de Datos Utilizada

El proyecto utiliza la base de datos Pubs, una base de datos de ejemplo orientada al manejo de información relacionada con editoriales y ventas.

Entre las principales entidades utilizadas se encuentran:

- Authors
- Titles
- Publishers
- Stores
- Sales

---

# Operaciones Implementadas

## Unión (∪)

Se desarrollaron consultas para combinar conjuntos compatibles eliminando duplicados.

Ejemplos implementados:
- Ciudades de autores y editoriales
- Estados de autores y tiendas
- Nombres de editoriales y tiendas

---

## Diferencia (−)

Se implementaron consultas para identificar registros presentes en una consulta pero no en otra.

Ejemplos implementados:
- Ciudades de autores que no aparecen en editoriales
- Estados de tiendas que no aparecen en autores
- Editoriales sin coincidencia con tiendas

---

## Producto Cartesiano (×)

Se desarrollaron consultas para generar todas las posibles combinaciones entre registros de diferentes entidades.

Ejemplos implementados:
- Autores y títulos
- Tiendas y editoriales
- Autores y tiendas

---

# Estructura del Proyecto

```text id="d84f0m"
Taller3.2/
│
├── Models/
├── Data/
├── Queries/
├── Screenshots/
├── Informe/
├── README.md
└── Taller3.2.sln
