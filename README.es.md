**Languages:** [English](README.md) · [Español](README.es.md)

# nuget-package-publisher

Utilidad histórica para empaquetar y publicar proyectos NuGet.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2019.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2019-04-01**, [`PackagePublisher/PackagePublisherFramework/Program.cs`](PackagePublisher/PackagePublisherFramework/Program.cs); fecha de modificación conservada.
- Referencia adicional: destino `netcoreapp2.1` en [`PackagePublisher/PackagePublisher/PackagePublisher.csproj`](PackagePublisher/PackagePublisher/PackagePublisher.csproj); su [versión estable se publicó el 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

## Por qué merece la pena mirarlo

La herramienta reúne versionado, compilación, empaquetado y publicación en una secuencia automatizada. Su interés está en el proceso de entrega y en identificar qué partes conviene parametrizar al trasladarlo a otro entorno.

Puntos de entrada al código:

- [`PackagePublisher/PackagePublisherFramework/Program.cs`](PackagePublisher/PackagePublisherFramework/Program.cs)
- [`PackagePublisher/PackagePublisher/Program.cs`](PackagePublisher/PackagePublisher/Program.cs)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`PackagePublisher/`](PackagePublisher/) | Utilidades de consola para automatizar incremento de versión, compilación, empaquetado y publicación NuGet de proyectos, con limpieza posterior de artefactos. |

No se incluyen los paquetes de MyPackages ni los ejecutables de NuGet/CredentialProvider. Deben obtenerse o reconstruirse por separado.

## Requisitos y preparación

.NET Framework/.NET Core y NuGet CLI.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

Soluciones conservadas:

- `PackagePublisher/PackagePublisher.sln`

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.
