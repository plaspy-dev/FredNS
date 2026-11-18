# FredNS

[Español](#español) · [English](#english)

## Español

Panel web para administrar los dominios y registros de un servidor DNS. Ayuda a actualizar a qué dirección apunta un nombre cuando se cambia de servidor.

### Qué puedes hacer

- Consulta y administra los dominios alojados.
- Revisa y modifica los registros DNS de un dominio.
- Usa configuración de ejemplo para estudiar el flujo en un entorno local.

### Ejemplo

Usa `taller.example.invalid` como dominio ficticio y sigue cómo se cambiaría su registro de dirección en un DNS de pruebas.

### Cómo empezar

El sitio usa ASP.NET de su época. Revisa las páginas y su código en un entorno Windows compatible con .NET Framework. Para una ejecución local, identifica las conexiones que usa la aplicación y prepara una base vacía con datos de prueba. Las conexiones, recursos y servicios originales se gestionan por separado.

Puntos de entrada en el código. [`main.sln`](main.sln).

Las fechas del historial se apoyan en Git o en la evidencia disponible de los respaldos. Las fechas reconstruidas a partir de archivos sin zona horaria usan las 12:00 UTC como referencia.

## English

A web panel for managing DNS domains and records. It helps change where a name points when a service moves to another server.

### What you can do

- Review and manage hosted domains.
- Review and update a domain's DNS records.
- Use sample configuration to explore the workflow locally.

### Example

Use `taller.example.invalid` as a fictional domain and trace how its address record would change in a test DNS server.

### Getting started

The site uses historical ASP.NET. Review its pages and code in a Windows environment compatible with .NET Framework. To run locally, identify the connections the application uses and prepare an empty database with test data. Original connections, resources, and services are managed separately.

Entry points in the source. [`main.sln`](main.sln).

History dates come from Git or available backup evidence. Reconstructed dates from files with no time zone use 12:00 UTC as a reference.
