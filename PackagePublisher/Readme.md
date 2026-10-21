# PackagePublisher

Utilidades de consola para automatizar incremento de versión, compilación, empaquetado y publicación NuGet de proyectos, con limpieza posterior de artefactos.

Documentación basada en los archivos locales revisados el 21 de octubre de 2026.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2019.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2019-04-01**, [`PackagePublisher/PackagePublisherFramework/Program.cs`](PackagePublisherFramework/Program.cs); fecha de modificación conservada.
- Referencia adicional: destino `netcoreapp2.1` en [`PackagePublisher/PackagePublisher/PackagePublisher.csproj`](PackagePublisher/PackagePublisher.csproj); su [versión estable se publicó el 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

## Por qué merece la pena mirarlo

Encadena modificación de versión, compilación, empaquetado y publicación NuGet. Es interesante leerlo como automatización del proceso de entrega y observar qué decisiones estaban ligadas al entorno original.

Puntos de entrada al código:

- [`PackagePublisherFramework/Program.cs`](PackagePublisherFramework/Program.cs)
- [`PackagePublisher/Program.cs`](PackagePublisher/Program.cs)

<!-- END project-context -->

## Estructura y responsabilidades

| Ruta | Responsabilidad |
| --- | --- |
| `PackagePublisher/` | Versión del programa con destino .NET Core 2.1. |
| `PackagePublisherFramework/` | Versión .NET Framework 4.7.2 y artefactos de publicación ClickOnce. |
| `PackagePublisher.sln` | Solución de ambas variantes. |

## Tecnologías y requisitos

Windows, SDK .NET Core 2.1 o herramientas .NET Framework 4.7.2, MSBuild/NuGet y acceso al feed de destino según la variante.

Destinos leídos de los proyectos: `netcoreapp2.1`, `v4.7.2`.

## Preparación y arranque

Abrir PackagePublisher.sln y compilar la variante elegida después de revisar Program.cs. Main modifica el archivo de proyecto, ejecuta procesos de compilación/publicación y borra artefactos; no se ejecutó automáticamente.

Soluciones presentes: `PackagePublisher.sln`.

## Configuración e integraciones

Revisar rutas locales, nombre del proyecto, comandos NuGet, origen de paquetes y autenticación. La carpeta incluye un certificado temporal PFX y un perfil .pubxml.user.

## Estado de esta copia

Relacionado con los ejecutables PackagePublisherFramework.exe copiados en proyectos Mentor y con la colección MyPackages. Las instrucciones existentes están ligadas al entorno original y requieren adaptación.

La revisión fue estática: no se restauraron dependencias, no se compiló ni se ejecutaron aplicaciones o pruebas. Los comandos anteriores son instrucciones de preparación, no resultados de validación. Las versiones indicadas son las del código conservado.


## Copia pública

Las credenciales originales se han retirado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Los datos locales, sesiones, certificados privados y perfiles de despliegue se omiten. Configurar servicios y credenciales propios antes de ejecutar. La compilación y el funcionamiento con servicios externos no se han validado.
