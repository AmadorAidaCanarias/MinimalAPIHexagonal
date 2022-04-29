# Minimal API Net6

## Descripción
Se ha agregado la arquitectura a la Minimal API según lo expuesto por Rober C. Martin en su blog sobre Hexagonal ➡️ [Blog de Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html).

El API (y proyecto de inicio) está en API_FrameworksAndAdapters -> UI.

## TODO IMPORTANT
Recuerda cambiar la cadena de conexión del Settings en el API y en el archivo ApplicationDbContextFactory del proyecto GatewaySqlServer.

Luego Ejecuta las migraciones para poder tener una base de datos 🧐

## Instrucciones de nivel superior (Top-Level Statements)

Desde C# 9 parece que se puede empezar a reducir el código de una aplicación de consola [Artículo 📖](https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/program-structure/top-level-statements).

Y con C# 10 ya las aplicaciones de consola implementan por defecto este tipo de instrucciones [Artículo 📖](https://docs.microsoft.com/es-es/dotnet/core/tutorials/top-level-templates).

## Minimal API

Podemos encontrar una introducción al concepto de [Minimal API](https://docs.microsoft.com/es-es/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-6.0) y un [pequeño tutorial](https://docs.microsoft.com/es-es/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio) en la documentación oficial de Microsoft para iniciarse. Que además, podemos comparar con el tutorial de iniciación a las [API de Controladores](https://docs.microsoft.com/es-es/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio).
