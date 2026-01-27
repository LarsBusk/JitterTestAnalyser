# JitterTestAnalyser .NET 10.0 Upgrade Tasks

## Overview

Upgrade the `JitterTestAnalyser` solution and its single project from `net48` to `net10.0-windows`, converting the project to SDK-style, restoring dependencies, and resolving compilation issues. The upgrade is performed as an atomic code change followed by automated test execution if test projects exist.

**Progress**: 0/4 tasks complete (0%) ![0%](https://progress-bar.xyz/0)

---

## Tasks

### [▶] TASK-001: Verify prerequisites
**References**: Plan §Phase 0, Plan §4

- [▶] (1) Verify .NET 10 SDK is installed on the execution environment per Plan §Phase 0
- [ ] (2) Runtime/SDK version meets minimum requirements (`dotnet --version`) (**Verify**)
- [ ] (3) Verify IDE/CI tooling supports .NET 10 and Windows desktop workloads per Plan §Phase 0 (install if required)
- [ ] (4) Check `global.json` (if present) for compatibility with .NET 10 per Plan §Phase 0 and Plan §4 (**Verify**)

### [ ] TASK-002: Atomic project-file conversion and framework update with compilation fixes
**References**: Plan §2, Plan §4, Plan §6

- [ ] (1) Convert `JitterTestAnalyser\JitterTestAnalyser.csproj` to SDK-style and update project properties per Plan §4:
  - Set `TargetFramework` to `net10.0-windows`
  - Enable Windows desktop support (`<UseWindowsForms>true</UseWindowsForms>` or `Sdk="Microsoft.NET.Sdk.WindowsDesktop"`)
  - Migrate references (COM/resources) and preserve necessary assembly attributes per Plan §4
- [ ] (2) Migrate package references to `<PackageReference>` format if present (per Plan §5) and add any compatibility packages required by Plan §4 (e.g., `System.Configuration.ConfigurationManager`) 
- [ ] (3) Restore dependencies for the solution (`dotnet restore`) per Plan §3
- [ ] (4) Build the solution and fix all compilation errors arising from the framework and package changes, addressing breaking changes referenced in Plan §6
- [ ] (5) Solution builds with 0 errors (**Verify**)

### [ ] TASK-003: Run automated tests and validate upgrade
**References**: Plan §7, Plan §6

- [ ] (1) Detect and run any test projects listed in the plan (if present) per Plan §7 (e.g., `dotnet test` on test projects)
- [ ] (2) Fix any test failures caused by upgrade changes (reference Plan §6 for common fixes)
- [ ] (3) Re-run automated tests after fixes
- [ ] (4) All automated tests pass with 0 failures (**Verify**)

### [ ] TASK-004: Final commit
**References**: Plan §9

- [ ] (1) Commit all remaining changes with message: "TASK-004: Complete upgrade to .NET 10.0 (net10.0-windows)"
