---
description: Creates a random chore commit message.
---

# convent-cli commit chore

## Usage

```bash
convent-cli commit [<path>] chore
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

### Example 1: Create a chore commit message with a description only

```bash
convent-cli commit . chore
```

### Example 2: Create a chore commit message which includes a scope

```bash
convent-cli commit . chore --scope
```

### Example 3: Create a feature commit message in a specific repository

```bash
convent-cli commit /path/to/repository chore
```

