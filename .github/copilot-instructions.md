# Copilot instructions for vibe coding

This repository is a starter for AI-assisted development using GitHub Copilot.

## Coding style and workflow

- Keep changes focused and small.
- Prefer clear, readable code over clever code.
- Add tests for behavior changes when a test project exists.
- Explain tradeoffs briefly in pull request descriptions.

## .NET guidance

- Target modern .NET and use SDK-style projects.
- Prefer dependency injection and strongly typed configuration.
- Use async APIs for I/O operations.
- Validate inputs at boundaries and return meaningful errors.
- Avoid static mutable state unless required.

## Azure guidance

- Prefer managed identities over secrets where possible.
- Keep infrastructure as code in Bicep or Terraform.
- Use least-privilege role assignments.
- Use region-aware design and resilient retry patterns for SDK clients.
- Capture telemetry with Application Insights/OpenTelemetry for production workloads.

## AI-assisted implementation guidance

- Ask Copilot for multiple implementation options before picking one.
- Request explicit assumptions and edge cases.
- Ask Copilot to propose tests and failure handling.
- When touching cloud resources, ask for cost and security implications.

## Security and privacy

- Do not hardcode credentials, API keys, or connection strings.
- Keep sensitive values in environment variables or secret stores.
- Redact secrets from logs and sample payloads.
