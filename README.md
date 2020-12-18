# Convent

Convent is a library for the generation of random [conventional commit messages (v1.0.0)](https://www.conventionalcommits.org/en/v1.0.0/). A command line interface and web api have also been provided which expose the library for terminals and web clients respectively.

## Motivation

Sometimes you might find yourself needing to generate random commit messages which follow the conventional commits specification.
You might want to play around with branching and versioning strategies, or tooling which uses conventional commits to generate
changelogs or other release artifacts. In cases such as this you can use Convent to generate messages which follow the specification,
but are random.

Convent is not intended to create commit messages for use in real projects, you should write those yourself.

## Pre-requisites

Before working with Convent you'll need to have the following installed.

- Net Core 3.1 SDK.

## Using the `Convent.Commits` package

```csharp
// TODO: Add NuGet package reference.
using Convent.Commits;

var commitFactory = new ConventionalCommitMessageFactory();

// =================================
// Create a feature commit message.
commitFactory.CreateCommitMessage(new FeatureCommitType());

// feat: payment green sensor


// =============================
// Create a fix commit message.
commitFactory.CreateCommitMessage(new FixCommitType());

// fix: Kansas down-sized


// ===============================
// Create a chore commit message.
commitFactory.CreateCommitMessage(new ChoreCommitType());

// chore: innovative orchestrator interactions


// ===================
// Providing options.
var options =  new CommitMessageOptions
{
    HasScope = true,
    HasBody = true,
    HasIssue = true,
    HasBreakingChange = true,
};

// Equivalent to:
options = CommitMessageOptions.All;

commitFactory.CreateCommitMessage(new FeatureCommitMessage(), options)

// feat(games): licensed extension RAM
// Tasty New York
// Closes #2733
// BREAKING CHANGE: Music
```

### Extending Convent

Extending Convent is not currently possible. This is planned for the future, but was not in scope as part of
the initial design.

## Using `Convent.Cli`

To use the command line interface [TODO: download and install].

```powershell
# ==========
# Get help.
convent-cli --help


# =====================
# Display the version.
convent-cli --version


# =================================
# Create a feature commit message.
> convent-cli feature

feat: payment green sensor


# =============================
# Create a fix commit message.
> convent-cli fix

fix: Kansas down-sized


# ===============================
# Create a chore commit message.
> convent-cli chore

chore: innovative orchestrator interactions


# ===================
# Providing options.
> convent-cli --scope `
>             --body `
>             --issue `
>             --breaking-change

# Or using aliases:
> convent-cli -sbi --breaking-change

feat(games): licensed extension RAM
Tasty New York
Closes #2733
BREAKING CHANGE: Music
```
