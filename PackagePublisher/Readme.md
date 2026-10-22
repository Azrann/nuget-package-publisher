**Languages:** [English](Readme.md) · [Español](README.es.md)

# PackagePublisher

Console utilities to automate project version increments, builds, packaging, and NuGet publishing, followed by artifact cleanup.

Documentation based on local files reviewed on 21 October 2026.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2019.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2019-04-01**, [`PackagePublisher/PackagePublisherFramework/Program.cs`](PackagePublisherFramework/Program.cs); preserved modification timestamp.
- Additional reference: target `netcoreapp2.1` in [`PackagePublisher/PackagePublisher/PackagePublisher.csproj`](PackagePublisher/PackagePublisher.csproj); its [stable release was published on 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

## Why this is worth exploring

Chains version modification, compilation, packaging, and NuGet publishing. Read it as delivery process automation and identify which decisions were tied to the original environment.

Code entry points:

- [`PackagePublisherFramework/Program.cs`](PackagePublisherFramework/Program.cs)
- [`PackagePublisher/Program.cs`](PackagePublisher/Program.cs)

<!-- END project-context -->

## Structure and responsibilities

| Path | Responsibility |
| --- | --- |
| `PackagePublisher/` | Program variant targeting .NET Core 2.1. |
| `PackagePublisherFramework/` | .NET Framework 4.7.2 variant and ClickOnce publish artifacts. |
| `PackagePublisher.sln` | Solution containing both variants. |

## Technologies and requirements

Windows, the .NET Core 2.1 SDK or .NET Framework 4.7.2 tools, MSBuild/NuGet, and destination feed access depending on the variant.

Targets read from project files: `netcoreapp2.1`, `v4.7.2`.

## Setup and startup

Open PackagePublisher.sln and build the chosen variant after reviewing Program.cs. Main modifies the project file, executes build/publish processes, and deletes artifacts; it was not run automatically.

Solutions present: `PackagePublisher.sln`.

## Configuration and integrations

Review local paths, project name, NuGet commands, package source, and authentication. The folder includes a temporary PFX certificate and a .pubxml.user profile.

## Status of this copy

Related to the PackagePublisherFramework.exe copies in Mentor projects and the MyPackages collection. Existing instructions are tied to the original environment and require adaptation.

The review was static: dependencies were not restored, and applications and tests were neither built nor run. The commands above are setup instructions, not validation results. Listed versions describe the preserved code.


## Public copy

Original credentials have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Local data, sessions, private certificates, and deployment profiles are omitted. Configure your own services and credentials before running. Building and operation with external services have not been validated.
