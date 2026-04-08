# Getting started (beginner guide)

This guide assumes you are new to coding and want to build with GitHub Copilot in VS Code.

## Goal of this repository

Use AI to help you create, explain, and improve code while following safe .NET and Azure practices.

## First-time setup

1. Install Docker Desktop.
2. Install Visual Studio Code.
3. Install the Dev Containers extension in VS Code.
4. Open this repository in VS Code.
5. Run Dev Containers: Reopen in Container.

## Sign in once

1. Sign in to GitHub in VS Code (for Copilot).
2. In the terminal inside VS Code, run:

```bash
gh auth login
```

3. Optional: sign in to Azure if you are deploying to Azure:

```bash
az login
```

## Verify your environment

Run the VS Code task named:

- Verify vibe coding environment

This checks whether dotnet, Azure CLI, GitHub CLI, and Copilot CLI are available.

## Your first Copilot steps

1. Open Copilot Chat in VS Code.
2. Ask: Explain this repository to a complete beginner.
3. Ask: Create a tiny C# console app that prints hello and explain every line.
4. Ask: Add one test and explain why the test matters.

## Terminal Copilot examples

```bash
copilot -i "create a C# method to validate an email"
copilot -p "explain dotnet test"
```

## Safe prompting habits

- Ask for assumptions before code.
- Ask for edge cases and failure paths.
- Ask for tests with every non-trivial change.
- Ask for a plain-English explanation after generated code.

## If something does not work

1. Rebuild the container:
   - Dev Containers: Rebuild and Reopen in Container
2. Re-run the Verify vibe coding environment task.
3. Ask Copilot Chat: Help me debug my dev container setup in this repo.
