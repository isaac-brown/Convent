---
description: Creates a random chore commit message.
---

# chore

## Usage

```bash
convent-cli commit chore
[--scope <bool>]
[--body <bool>]
[--issue <bool>]
[--breaking-change <bool>]
```

## Options

The `chore` subcommand includes all [common options](./#common-options) from the `commit` command.

## Examples

### Example 1: Create a chore commit message with a description only

```bash
> convent-cli commit chore

chore: Communications
```

### Example 2: Create a chore commit message which includes a scope

```bash
> convent-cli commit chore --scope

chore(kina): aggregate
```

### Example 3: Create a chore commit message which includes all optional elements

```bash
> convent-cli commit chore --scope --body --issue --breaking-change

chore(accounts-generate): deposit
Tanzanian Shilling static online
Closes #2723
BREAKING CHANGE: Buckinghamshire HTTP Cliffs
```

