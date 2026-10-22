**Languages:** [English](README.md) · [Español](README.es.md)

# nuget-package-publisher

Historical utility for packaging and publishing NuGet projects.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2019.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2019-04-01**, [`PackagePublisher/PackagePublisherFramework/Program.cs`](PackagePublisher/PackagePublisherFramework/Program.cs); preserved modification timestamp.
- Additional reference: target `netcoreapp2.1` in [`PackagePublisher/PackagePublisher/PackagePublisher.csproj`](PackagePublisher/PackagePublisher/PackagePublisher.csproj); its [stable release was published on 2018-05-30](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

## Why this is worth exploring

The tool combines versioning, compilation, packaging, and publishing into an automated sequence. Its value is the delivery process and identifying what should be parameterized when moving to another environment.

Code entry points:

- [`PackagePublisher/PackagePublisherFramework/Program.cs`](PackagePublisher/PackagePublisherFramework/Program.cs)
- [`PackagePublisher/PackagePublisher/Program.cs`](PackagePublisher/PackagePublisher/Program.cs)

<!-- END project-context -->

## Contents

| Directory | Function |
| --- | --- |
| [`PackagePublisher/`](PackagePublisher/) | Console utilities to automate project version increments, builds, packaging, and NuGet publishing, followed by artifact cleanup. |

MyPackages packages and NuGet/CredentialProvider executables are not included. Obtain or rebuild them separately.

## Requirements and setup

.NET Framework/.NET Core and NuGet CLI.

This is a historical copy. Consult each component's project files and README for versions and dependencies. Restore NuGet/npm from the appropriate folder; internal libraries may need rebuilding. Prepare databases and external services using your own accounts.

Preserved solutions:

- `PackagePublisher/PackagePublisher.sln`

## Configuration and security

Original secrets have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Search for this marker before running and provide values through local configuration or environment variables. Sessions, private keys, signing certificates, databases, logs, deployment profiles, and binary packages are not published. The `.gitignore` protects these local files.

A fresh history is published: old commits remain only in the original local copy. Example values cannot connect to the original services.

## Validation status

A static review and secret scan were performed before publication. Applications, trading operations, deployments, and tests contacting external services were not run. Building with current tools is not guaranteed. Some projects need historical dependencies and assets that are not included.

## Licenses and provenance

Third-party licenses and attributions present in the code are retained. No blanket license is added to components that lacked one. This import preserves local sources and does not claim to be a current version of the original project.
