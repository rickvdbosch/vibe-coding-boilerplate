# Vibe coding boilerplate

Starter repository for AI-assisted .NET development with GitHub Copilot, Dev Containers, and Azure guidance.

## What this repo is for

Beginners learning to code with AI assistance. Changes should stay small, readable, and tested.

Copilot-specific coding guidance lives in [.github/copilot-instructions.md](.github/copilot-instructions.md).

## Build and test

```powershell
# Build (from repo root)
dotnet build samples/hello-dotnet/HelloDotnetSample.slnx

# Run tests (from repo root)
dotnet test samples/hello-dotnet/HelloDotnetSample.slnx
```

Always run tests after any change to verify nothing is broken.

## Repo structure

| Path | Purpose |
| - | - |
| `.github/copilot-instructions.md` | GitHub Copilot workspace instructions |
| `.github/instructions/` | Scoped instructions (e.g. .NET and Azure best practices) |
| `.github/agents/` | Custom Copilot agent definitions |
| `.github/prompts/` | Reusable prompt templates |
| `docs/` | Beginner guides and starter prompts |
| `samples/hello-dotnet/` | Minimal .NET sample app with tests |

## Conventions

- Target .NET 10 with SDK-style projects.
- Every non-trivial code change needs at least one test.
- Use `ILogger<T>` for logging; never `Console.WriteLine` in production paths.
- Use `async`/`await` for all I/O operations.
- Prefer dependency injection over static helpers.
- No hardcoded secrets, API keys, or connection strings anywhere in the repo.

## Azure guidance

- Use managed identities instead of passwords or keys.
- Infrastructure goes in Bicep or Terraform under an `infra/` folder if added.
- Full guidance: [.github/instructions/dotnet-azure-best-practices.instructions.md](.github/instructions/dotnet-azure-best-practices.instructions.md).
