# .github/upgrades/plan.md

## Moving to Planning Stage

The assessment has identified what needs to change for your .NET 10 Upgrade. Now I'll create a detailed specification explaining *how* to make those changes.

### What I'll Create

A comprehensive `plan.md` that transforms assessment findings into an actionable roadmap:

- **Migration Strategy** — The approach best suited to your codebase (All-At-Once Strategy).
- **Execution Sequence** — Dependency-ordered steps ensuring nothing breaks along the way.
- **Risk Mitigation** — Strategies to handle potential issues before they occur.
- **Validation Checkpoints** — Clear success criteria for each phase.

This plan becomes the blueprint for the Execution stage, where actual changes will be applied systematically.

Let's build your migration plan!

---

# Migration Plan: Upgrade to .NET 10.0 (net10.0-windows)

## Table of contents

1. Executive Summary
2. Migration Strategy (All-At-Once)
3. Detailed Dependency Analysis
4. Project-by-Project Plans
5. Package Update Reference
6. Breaking Changes Catalog
7. Testing & Validation Strategy
8. Risk Management and Mitigation
9. Source Control Strategy
10. Success Criteria
11. Appendix: Assessment references

---

## 1. Executive Summary

Scenario: Upgrade solution `JitterTestAnalyser.sln` and its projects from `.NET Framework 4.8 (net48)` to `.NET 10.0 (net10.0-windows)` using the All-At-Once Strategy.

Scope:
- Projects affected: 1 (`JitterTestAnalyser\JitterTestAnalyser.csproj`)
- Current TFM: `net48`
- Proposed TFM: `net10.0-windows`
- Project style: Classic (non-SDK-style)
- Total code files: 16
- LOC: 2436
- Files with incidents: 9
- API issues: 1103+ APIs requiring change (binary/source incompatibilities and behavioral changes)

Rationale for All-At-Once:
- Small solution (1 project)
- Single codebase boundary (no project-to-project dependencies)
- Clear project-level work: convert project to SDK-style and enable Windows desktop support
- Faster end-to-end upgrade with coordinated package and project file updates

Key risks:
- High number of Windows Forms API incompatibilities (major portion of code changes)
- Project must be converted to SDK-style and Windows desktop support enabled
- Some legacy technologies (LINQ-to-SQL, configuration) require code changes or bridging packages

Primary deliverables:
- `plan.md` (this document)
- A single atomic upgrade change set (branch `upgrade-to-NET10`) that converts project file(s), updates TFMs, and updates packages

---

## 2. Migration Strategy

Selected Strategy: **All-At-Once Strategy** — all project and project-related files are upgraded simultaneously in a single coordinated operation.

Justification:
- Solution contains a single project: atomic upgrade reduces overhead and is low risk relative to multi-project solutions.
- Assessment indicates no NuGet package-level security vulnerabilities requiring separate handling.

Key principles applied:
- Convert project file(s) to SDK-style and update `TargetFramework` to `net10.0-windows` in the same atomic change.
- Enable Windows desktop support via the appropriate SDK or MSBuild properties.
- Apply all package updates (none required per assessment) and restore.
- Build and fix all compile errors in the same pass.
- Run tests (if present) after successful build.

Phases (conceptual, not split into separate commits):
- Phase 0: Prerequisites and environment verification
- Phase 1: Atomic Upgrade (project file conversion, TFM update, package updates)
- Phase 2: Build, Fix Compilation Issues, and Validate
- Phase 3: Run Tests and Final Verification

Note: The actual execution must be done by an executor; this plan only documents the steps.

---

## 3. Detailed Dependency Analysis

Summary:
- Single project: `JitterTestAnalyser\JitterTestAnalyser.csproj`
- No project-to-project dependencies identified
- No external NuGet packages recorded in assessment (0 packages)

Implication:
- Dependency order is trivial; conversion and upgrade can be performed purely at project level
- Windows Forms and legacy platform APIs are the main compatibility surface to address

Critical path:
1. Convert project to SDK-style and enable Windows desktop support
2. Update `TargetFramework` to `net10.0-windows`
3. Restore and build; resolve API-breaking issues

Circular dependencies: none

---

## 4. Project-by-Project Plans

Note: All projects are upgraded simultaneously (All-At-Once). The following is the per-project specification for `JitterTestAnalyser`.

### Project: `JitterTestAnalyser\JitterTestAnalyser.csproj`

Current State:
- TargetFramework: `net48`
- SDK-style: No (classic .csproj)
- Project type: Classic WinForms
- LOC: 2436
- Files with incidents: 9
- Primary issues from assessment: 1099 binary-incompatible APIs, 3 source incompatible, 1 behavioral change

Target State:
- TargetFramework: `net10.0-windows`
- SDK-style: Yes (SDK-style .csproj)
- Windows desktop support enabled
- All package updates applied (none required per assessment)

Migration Steps (atomic):
1. Prerequisites (local developer machine):
   - Install .NET 10 SDK on all developer and CI machines (validate manually).
   - Ensure Visual Studio supports .NET 10 and Windows desktop development workloads.
   - Backup repo and ensure branch `upgrade-to-NET10` is created from `EntityFramework` (or current source branch).

2. Project-file conversion & TFM update (single change):
   - Convert classic project file to SDK-style. Key points:
     - Replace legacy `<Project>` content with an SDK-style `<Project Sdk="Microsoft.NET.Sdk">
       ...</Project>` or `Microsoft.NET.Sdk.WindowsDesktop` if preferred.
     - Add `<PropertyGroup>` elements:
       - `<TargetFramework>net10.0-windows</TargetFramework>`
       - `<UseWindowsForms>true</UseWindowsForms>` or use `Sdk="Microsoft.NET.Sdk.WindowsDesktop"` and `<UseWindowsForms>true</UseWindowsForms>`
       - Preserve other important assembly attributes (AssemblyInfo or migrate to SDK-generated if applicable)
     - Translate/Add any explicit references to COM, resources, or embedded files into the SDK-style format (see Appendix for patterns).
   - Ensure package references (none per assessment) are migrated to `<PackageReference>` items.
   - Keep `app.config` for compatibility but plan to migrate config to `appsettings.json` or `System.Configuration.ConfigurationManager` as needed.

3. Restore and Build (atomic verification step):
   - Run `dotnet restore` (or use IDE restore) and `dotnet build` for the solution.
   - Capture compilation errors; categorize them into:
     - Windows Forms API replacements/adjustments
     - LINQ-to-SQL / data access incompatibilities
     - Obsolete APIs and source-level fixes

4. Apply Code Changes (same atomic window):
   - Address binary-incompatible APIs noted in assessment (majority are WinForms control properties and constructors). Typical edits:
     - Adjust constructor calls if signatures changed
     - Replace removed properties/members with supported equivalents
     - For designer-generated code: consider re-generating or migrating Designer files after project conversion to the Windows Forms designer support in SDK-style projects
   - For LINQ-to-SQL usage: evaluate migrating to EF Core or keep LINQ-to-SQL via compatibility packages if feasible; update data-access code accordingly.
   - For legacy configuration: consider adding `System.Configuration.ConfigurationManager` NuGet package as a bridge if immediate migration to `Microsoft.Extensions.Configuration` is not performed.

5. Rebuild and Iterate (single pass expectation):
   - Rebuild solution and resolve remaining compile errors.
   - Repeat code edits until solution builds cleanly.

6. Tests and Validation:
   - If unit/integration tests exist (none discovered), run them now.
   - Manual smoke test of UI flows to verify key Windows Forms behavior (note: this is a manual step and not part of automated task generation).

7. Finalize:
   - Commit all changes in a single atomic commit on branch `upgrade-to-NET10` per All-At-Once guidance.
   - Create a pull request for review and CI validation.

Validation Criteria (Project-level):
- Project file is SDK-style and contains `TargetFramework` `net10.0-windows` and `UseWindowsForms` set
- Solution builds with zero errors
- No NuGet security vulnerabilities reported
- Key UI flows smoke-tested and verified

---

## 5. Package Update Reference

Assessment reported **0 NuGet packages** for the solution. Therefore:
- No package update matrix is required.
- If future package updates are needed (for example `System.Configuration.ConfigurationManager` or EF Core), list them here with exact versions.

---

## 6. Breaking Changes Catalog

This catalog is derived from the assessment and groups likely breaking changes developers will encounter when migrating WinForms and legacy APIs to .NET 10.

High-impact items (focus areas):
- Windows Forms control APIs: property and constructor signature changes across many control types (Label, ComboBox, TextBox, RichTextBox, Button, CheckBox, GroupBox, TabControl, etc.)
- Designer-generated code: the WinForms designer and generated `.Designer.cs` code may need updating or re-generation under SDK-style projects and the newer Windows Forms designer.
- LINQ-to-SQL APIs: some `System.Data.Linq` types are binary-incompatible; evaluate migrating to EF Core or using bridging packages.
- Configuration: `app.config` behaviors and `System.Configuration` usage may require either the compatibility package or rework to new configuration model.

Representative API items (from assessment):
- `System.Windows.Forms.Label`, `System.Windows.Forms.ComboBox`, `System.Windows.Forms.TabPage`, `System.Windows.Forms.CheckBox`, `System.Windows.Forms.Button` — numerous binary-incompatible members
- `System.Data.Linq.Mapping.MappingSource` & `System.Data.Linq.DataContext` — legacy LINQ-to-SQL types with incompatibilities

Guidance for resolution:
- Prefer to re-generate WinForms designer code by opening forms in Visual Studio after project conversion (the designer will update code where necessary).
- Replace or adapt removed members with modern equivalents documented in Microsoft breaking-changes notes
- For LINQ-to-SQL, plan a migration path to EF Core where feasible, or identify compatibility NuGet packages as interim solution

Known unknowns:
- Some runtime behavior changes may only surface at manual UI test time; include manual smoke-testing in validation.

---

## 7. Testing & Validation Strategy

Levels of testing:
- Local build verification (mandatory)
- Automated unit tests (if present) — run after build
- Manual UI smoke tests — required for WinForms visual/behavioral checks

Checklist:
- [ ] dotnet build succeeds with 0 errors
- [ ] No unresolved compiler warnings related to API removal (address as needed)
- [ ] All automated tests pass (if applicable)
- [ ] Manual smoke tests for primary windows/forms flows

Test projects discovered: none in assessment. If tests exist, they must be updated to target `net10.0` and executed after upgrade.

---

## 8. Risk Management and Mitigation

Top risks:
- Large volume of WinForms API changes leading to significant code edits
- Designer and resource file incompatibilities after project conversion
- Data access migration complexity (LINQ-to-SQL)

Mitigations:
- Keep an atomic-feature branch `upgrade-to-NET10` and a single commit for the upgrade so it can be reverted easily
- Enable feature/CI pipeline that runs build and tests on pull request
- Use `System.Configuration.ConfigurationManager` as an interim compatibility package if migrating configuration system is larger effort
- Re-generate Designer files by opening forms in Visual Studio after conversion (do this under source control to capture changes)

Contingency:
- If blocking issues are found that cannot be remedied quickly (e.g., unsupported third-party components), consider reverting the branch and addressing the blocker via targeted changes (out of scope for this All-At-Once plan)

---

## 9. Source Control Strategy

Branching:
- Source branch: `EntityFramework` (current)
- Upgrade branch: `upgrade-to-NET10` (create from `EntityFramework` before making changes)

Commit strategy:
- Single atomic commit containing all project-file conversions, TFM updates, and code changes required to make the solution build under `net10.0-windows`.
- Include a PR description that references this plan and lists known risks and validation steps.

Pull request and review:
- Require CI build to succeed before merging
- Include reviewer checklist: build success, tests pass, manual smoke test performed, Designer code reviewed

Note: The All-At-Once strategy favors single atomic upgrade commit — capture all changes together to keep history clean and facilitate review.

---

## 10. Success Criteria

The migration is complete when all of the following are met:
- All projects target `net10.0-windows` (`TargetFramework` updated)
- Project files are converted to SDK-style
- Solution builds with 0 compilation errors
- No NuGet security vulnerabilities remain (assessment reported none)
- Manual smoke tests of the primary Windows Forms UI flows pass
- Changes are contained in `upgrade-to-NET10` branch and PR is created

---

## 11. Appendix: Assessment references

Assessment file: `.github/upgrades/assessment.md` (source of analysis data and API compatibility inventory)

---

# Iterations Log

**Iteration 1.1: Create Skeleton** — created `plan.md` skeleton with table of contents and section placeholders; skeleton now filled with initial content.

**Iteration 1.2: Discover & Classify** — used assessment data (single project, net48 -> net10.0-windows, heavy WinForms API incompatibilities). Classified solution as `Simple` (single project) and selected All-At-Once strategy.

**Iteration 2.1: Dependency Analysis** — dependency analysis added; trivial (single project, no inter-project deps).

**Iteration 2.2 & 2.3: Strategy and Project Stubs** — filled migration strategy and per-project plan for `JitterTestAnalyser` and added risk mitigation, testing, and source control guidance.

Plan generation complete. The file is ready for review.
