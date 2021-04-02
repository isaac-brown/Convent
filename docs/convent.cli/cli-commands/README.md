---
description: Explore the commands available in convent-cli.
---

# CLI commands

## Usage

```bash
convent-cli [options] [command]
```

## Options

### `--scope`

* Type: `boolean`
* Alias: `-s`
* Default: `false`

When true, adds a scope element to the commit message.

### `--body`

* Type: `boolean`
* Alias: `-b`
* Default: `false`

When true, adds a body element to the commit message.

### `--issue`

* Type: `boolean`
* Alias: `-i`
* Default: `false`

When true, adds an issue element to the commit message.

### `--breaking-change`

* Type: `boolean`
* Default: `false`

When true, adds a breaking change element to the commit message

### `--version`

Show version information

### `--help`

* Aliases: `-?`, `-h`

Show help and usage information

## Commands

### message

Creates commit messages. See the [message command](convent-cli-message/) for more info.

### commit

Create commits in a repository. See the [commit command](convent-cli-commit/) for more info.



