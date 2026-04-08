# Vibe coding boilerplate

Starter repository for vibe coding with GitHub Copilot, Dev Containers, .NET, and Azure-focused AI coding guidance.

## What is included

- Dev Container setup with common coding tools and Copilot extensions preinstalled.
- GitHub CLI + standalone Copilot CLI in the dev container for terminal-based Copilot.
- VS Code extension recommendations for Copilot, .NET, and Azure workflows.
- Beginner onboarding guide and starter prompt pack.
- One-click VS Code tasks for environment verification and quick Copilot terminal test.
- Workspace-level Copilot instructions for agent-style coding and Azure/.NET best practices.

## Quick start

1. Open this folder in VS Code.
2. Reopen in container when prompted, or run: Dev Containers: Reopen in Container.
3. Sign in to GitHub for Copilot and to Azure if needed.
4. Optional for terminal Copilot: run gh auth login.
5. Start coding with Copilot Chat using the guidance in this repository.
6. Run the VS Code task: Verify vibe coding environment.

## VS Code tasks

Tasks are defined in [.vscode/tasks.json](.vscode/tasks.json):

- Verify vibe coding environment
- Copilot terminal quick test
- GitHub CLI auth status

How to run a task:

1. Open the Command Palette with Ctrl+Shift+P.
2. Run Tasks: Run Task.
3. Select one of the task names above.

Alternative:

1. Open the Terminal menu.
2. Select Run Task....
3. Choose the task you want.

## New to coding?

- Follow [docs/getting-started.md](docs/getting-started.md) for a gentle introduction to coding with AI assistance.
- Try beginner prompts in [docs/starter-prompts.md](docs/starter-prompts.md).

## Tiny sample .NET app

A minimal sample is included in a separate folder so beginners can run something immediately:

- samples/hello-dotnet

Run the sample test from the repository root:

```powershell
dotnet test samples/hello-dotnet/HelloDotnetSample.slnx
```

## Files you should know

- .devcontainer/devcontainer.json
- .vscode/extensions.json
- .vscode/tasks.json
- .github/copilot-instructions.md
- .github/instructions/dotnet-azure-best-practices.instructions.md
- docs/getting-started.md
- docs/starter-prompts.md
- samples/hello-dotnet

## Notes

- This boilerplate is intentionally lightweight so teams can add language/framework specifics without removing baseline AI coding standards.
