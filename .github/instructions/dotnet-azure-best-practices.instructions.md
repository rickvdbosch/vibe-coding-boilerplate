---
applyTo: "**"
---

# .NET and Azure best practices for AI coding agents

Use these instructions when generating or reviewing code in this repository.

## General engineering

- Keep pull requests small and easy to review.
- Preserve existing architecture unless change is required.
- Add concise comments only where code intent is not obvious.

## .NET implementation

- Prefer `ILogger<T>` for logging and include structured properties.
- Use cancellation tokens in async methods that do I/O.
- Use `IOptions<T>` for configuration binding and validation.
- Return typed results and avoid using exceptions for control flow.
- Write unit tests for business logic and integration tests for external dependencies.

## Azure implementation

- Use `DefaultAzureCredential` for local + cloud auth flows when possible.
- Enable retries with exponential backoff for transient failures.
- Keep service clients long-lived and reusable.
- Favor idempotent operations in background or retryable workflows.
- Define access with RBAC and scope roles as narrowly as possible.

## Observability

- Use correlation ids across logs and external calls.
- Emit traces/metrics for dependency calls and latency-sensitive paths.
- Keep logs useful but free of PII and secrets.

## Cost and reliability

- Prefer right-sized service SKUs and autoscaling for variable load.
- Design for graceful degradation when dependencies are unavailable.
- Avoid chatty cross-region dependencies in latency-sensitive paths.
