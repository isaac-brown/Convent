---
description: Creates a random fix commit message.
---

# convent-cli commit fix

## Usage

```bash
convent-cli commit [<path>] fix
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

### Example 1: Create a fix commit message with a description only

```bash
convent-cli commit . fix
```

### Example 2: Create a fix commit message which includes a scope

```bash
convent-cli commit . fix --scope
```

### Example 3: Create a fix commit message in a specific repository

```bash
convent-cli commit /path/to/repository fix
```

