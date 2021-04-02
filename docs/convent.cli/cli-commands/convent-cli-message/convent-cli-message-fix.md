---
description: Creates a random fix commit message.
---

# convent-cli message fix

## Usage

```bash
convent-cli message fix
    [--scope <bool>]
    [--body <bool>]
    [--issue <bool>]
    [--breaking-change <bool>]
```

## Options

The `chore` subcommand includes all [common options](../#options).

## Examples

### Example 1: Create a fix commit message with a description only

```bash
> convent-cli message fix

fix: parse Handcrafted
```

### Example 2: Create a fix commit message which includes a scope

```bash
> convent-cli message fix --scope

fix(club-licensed): Wooden Intelligent Rubber Pants SAS
```

### Example 3: Create a fix commit message which includes all optional elements

```bash
> convent-cli message fix --scope --body --issue --breaking-change

fix(handcrafted-ai-niue): fuchsia
Organic
Closes #116
BREAKING CHANGE: maroon
```

