---
description: Creates a random feature commit message.
---

# feature

## Usage

```bash
convent-cli commit feature
[--scope <bool>]
[--body <bool>]
[--issue <bool>]
[--breaking-change <bool>]
```

## Options

The `feature` subcommand includes all [common options](./#common-options) from the `commit` command.

## Examples

### Example 1: Create a feature commit message with a description only

```bash
> convent-cli commit feature

feat: Wooden
```

### Example 2: Create a feature commit message which includes a scope

```bash
> convent-cli commit feature --scope

feat(shoes-forward-small): model black
```

### Example 3: Create a feature commit message which includes all optional elements

```bash
> convent-cli commit feature --scope --body --issue --breaking-change

feat(deposit-convertible-jewelery): multi-byte Ergonomic Mews
calculating wireless invoice
Closes #7174
BREAKING CHANGE: recontextualize Colorado
```

