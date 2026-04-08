# Starter prompts for vibe coding

Use these prompts in Copilot Chat when you are not sure how to begin.

## Learn the project

- Explain this repository like I am brand new to software development.
- What are the 3 safest first tasks I can do in this repo?
- Create a simple learning path for my first week with this repo.

## Build small features

- Propose 3 beginner-friendly .NET feature ideas. For each, give effort and risk.
- Implement option 1 with small commits and explain each file change.
- Add tests for this change and explain what each test protects.

## Improve code quality

- Review this code for bugs and security issues. Prioritize by severity.
- Refactor this code to be easier to read for a beginner.
- Add logging with ILogger<T> and explain why each log line exists.

## Azure-focused prompts

- Prepare this app for Azure deployment using managed identity and least privilege.
- Show me a minimal Bicep template for this app and explain each resource.
- Add retry and timeout handling for Azure SDK calls in this file.

## Debugging prompts

- I got this error. Explain the root cause in plain English and propose the safest fix.
- Show me 2 possible fixes and the tradeoffs.
- After fixing, add a test so this does not regress.

## Prompt pattern that works well

Use this template for stronger results:

```text
Goal: <what I want>
Context: <relevant files and constraints>
Requirements: <must-have behavior>
Output style: <step-by-step, beginner explanation>
Quality checks: <tests, edge cases, security>
```
