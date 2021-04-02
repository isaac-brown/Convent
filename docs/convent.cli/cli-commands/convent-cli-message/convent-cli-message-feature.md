---
description: Creates a random feature commit message.
---

# convent-cli message feature

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

### Example 1: Create a feature commit message with a description only

```bash
> convent-cli message feature

feat: Streamlined
```

### Example 2: Create a fix commit message which includes a scope

```bash
> convent-cli message feature --scope

feat(ergonomic-corporate-investor): Handcrafted Granite Keyboard deliverables
```

### Example 3: Create a fix commit message which includes all optional elements

```bash
> convent-cli message feature --scope --body --issue --breaking-change

feat(indexing-saint-analyst)!: Computers & Books Strategist
Crescent Euro white
Closes #963
BREAKING CHANGE: moderator
```

