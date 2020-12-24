---
description: Creates a random fix commit message.
---

# fix

## Usage

```bash
convent-cli commit fix
[--scope <bool>]
[--body <bool>]
[--issue <bool>]
[--breaking-change <bool>]
```

## Options

The `fix` subcommand includes all [common options](./#common-options) from the `commit` command.

## Examples

### Example 1: Create a fix commit message with a description only

```bash
> convent-cli commit fix

fix: parse Handcrafted
```

### Example 2: Create a fix commit message which includes a scope

```bash
> convent-cli commit fix --scope

fix(club-licensed): Wooden Intelligent Rubber Pants SAS
```

### Example 3: Create a fix commit message which includes all optional elements

```bash
> convent-cli commit fix --scope --body --issue --breaking-change

fix(handcrafted-ai-niue): fuchsia
Organic
Closes #116
BREAKING CHANGE: maroon
```

