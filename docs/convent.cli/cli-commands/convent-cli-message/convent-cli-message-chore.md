---
description: Creates a random chore commit message.
---

# convent-cli message chore

## Usage

```bash
convent-cli message chore
    [--scope <bool>]
    [--body <bool>]
    [--issue <bool>]
    [--breaking-change <bool>]
```

## Options

The `chore` subcommand includes all [common options](../#options).

## Examples

### Example 1: Create a chore commit message with a description only

```bash
> convent-cli message chore

chore: Communications
```

### Example 2: Create a chore commit message which includes a scope

```bash
> convent-cli message chore --scope

chore(kina): aggregate
```

### Example 3: Create a chore commit message which includes all optional elements

```bash
> convent-cli message chore --scope --body --issue --breaking-change

chore(accounts-generate): deposit
Tanzanian Shilling static online
Closes #2723
BREAKING CHANGE: Buckinghamshire HTTP Cliffs
```

