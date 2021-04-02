---
description: Learn how to publish Convent.Cli
---

# Publishing Convent.Cli

At present publishing involves the following steps:

1. Cut a release
2. Create zip files
3. Publish release files to GitHub

## Cut a release

* Create release: `npm run release`
* Push commit and tags: `git push --follow-tags`

## Create zip files

1. `.\eng\publish.ps1`

## Publish release files to GitHub

1. Copy zip files in `/release` with the correct version number
2. 
