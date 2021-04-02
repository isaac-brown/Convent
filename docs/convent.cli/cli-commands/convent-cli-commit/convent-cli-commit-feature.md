---
description: Creates a random feature commit message.
---

# convent-cli-commit feature

## Usage

```bash
convent-cli commit [<path>] feature
    [--scope <bool>]
    [--body <bool>]
    [--issue <bool>]
    [--breaking-change <bool>]
```

## Arguments

### path

The path to the root of the repository which the commit will be applied.

## Options

Includes all [global options](../#options).

## Examples

### Example 1: Create a feature commit message with a description only

```bash
convent-cli commit . feature
```

### Example 2: Create a feature commit message which includes a scope

```bash
convent-cli commit . feature --scope
```

### Example 3: Create a feature commit message in a specific repository

```bash
convent-cli commit /path/to/repository feature
```

