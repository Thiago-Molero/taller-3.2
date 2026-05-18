# Taller 3 – Álgebra Relacional con Entity Framework

## Descripción del Proyecto

El presente proyecto tiene como finalidad comprender y aplicar las operaciones fundamentales del álgebra relacional utilizando ADO.NET Entity Framework, LINQ y bases de datos relacionales.

El trabajo se divide en dos partes:

- Taller 3.1 → Operaciones Unarias utilizando la base de datos Northwind.
- Taller 3.2 → Operaciones Binarias utilizando la base de datos Pubs.

Durante el desarrollo del proyecto se implementaron diferentes consultas declarativas en C# para manipular información mediante Entity Framework y LINQ.

---

# Objetivos

## Objetivo General

Aplicar operaciones del álgebra relacional utilizando Entity Framework y LINQ en bases de datos relacionales.

---

## Objetivos Específicos

- Implementar operaciones unarias y binarias del álgebra relacional.
- Manipular información mediante consultas declarativas.
- Utilizar LINQ para desarrollar consultas organizadas y legibles.
- Comprender el funcionamiento de las operaciones relacionales en escenarios prácticos.
- Fortalecer habilidades relacionadas con acceso y manipulación de datos.

---

# Tecnologías Utilizadas

- C#
- .NET
- ADO.NET Entity Framework
- LINQ
- SQL Server
- Visual Studio
- GitHub

---

# Bases de Datos Utilizadas

## Northwind

Base de datos orientada a la gestión comercial de productos, clientes, pedidos y empleados.

Entidades utilizadas:
- Products
- Customers
- Categories
- Orders
- Employees

---

## Pubs

Base de datos orientada al manejo de información relacionada con editoriales, autores y ventas.

Entidades utilizadas:
- Authors
- Titles
- Publishers
- Stores
- Sales

---

# Taller 3.1 – Operaciones Unarias

En esta sección se implementaron operaciones unarias del álgebra relacional utilizando la base de datos Northwind.

## Operaciones Implementadas

### Selección (σ)

Consultas utilizadas para filtrar registros según condiciones específicas.

Ejemplos:
- Productos con precio mayor a 50
- Clientes pertenecientes a México
- Productos con stock dentro de un rango

---

### Proyección (π)

Consultas utilizadas para seleccionar atributos específicos de las entidades.

Ejemplos:
- Nombre y precio de productos
- Nombre y país de clientes
- Categorías registradas

---

# Taller 3.2 – Operaciones Binarias

En esta sección se implementaron operaciones binarias del álgebra relacional utilizando la base de datos Pubs.

## Operaciones Implementadas

### Unión (∪)

Consultas utilizadas para combinar conjuntos compatibles eliminando duplicados.

Ejemplos:
- Ciudades de autores y editoriales
- Estados de autores y tiendas
- Nombres de editoriales y tiendas

---

### Diferencia (−)

Consultas utilizadas para identificar registros presentes en una consulta pero no en otra.

Ejemplos:
- Ciudades de autores que no aparecen en editoriales
- Estados de tiendas que no aparecen en autores
- Editoriales sin coincidencia con tiendas

---

### Producto Cartesiano (×)

Consultas utilizadas para generar todas las posibles combinaciones entre registros.

Ejemplos:
- Autores y títulos
- Tiendas y editoriales
- Autores y tiendas

---

# Estructura del Proyecto

```text
Taller3/
│
├── Taller3.1/
│   ├── Models/
│   ├── Queries/
│   ├── Screenshots/
│   └── Informe/
│
├── Taller3.2/
│   ├── Models/
│   ├── Queries/
│   ├── Screenshots/
│   └── Informe/
│
├── README.md
└── index.html
