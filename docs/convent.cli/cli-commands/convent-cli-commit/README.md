---
description: Commands for working with commit messages.
---

# convent-cli commit

The`commit` command \(and it's sub-commands\) provides a set of commands for working with commit messages. At this stage only commit message creation is available.

## Common options

The following options are common across all subcommands of `commit` .

### --scope

When `true`, adds a scope element to the commit message.

| Type | `boolean` |
| :--- | :--- |
| Aliases | `-s` |
| Position | Named |
| Default value | `false` |

### --body

When `true`, adds a body element to the commit message.

| Type | `boolean` |
| :--- | :--- |
| Aliases | `-b` |
| Position | Named |
| Default value | `false` |

### --issue

When `true`, adds an issue element to the commit message.

| Type | `boolean` |
| :--- | :--- |
| Aliases | `-i` |
| Position | Named |
| Default value | `false` |

### --breaking-change

When `true`, adds a breaking change element to the commit message.

| Type | `boolean` |
| :--- | :--- |
| Position | Named |
| Default value | `false` |

