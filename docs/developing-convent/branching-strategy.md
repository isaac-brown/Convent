---
description: Learn about the branching strategy employed across Convent repositories.
---

# Branching strategy

### `master` branch

* `master` is where "production" code lives
* stable releases are cut from master
* master should always point to 

## release branch

* Format `release/v{major}.{minor}.x` for example `release/v1.0.x`
* Where stable release branches live
* Fixes can be applied to multiple release branches if needed.
* Branch off of `develop`
* Merge into `master` \(fast-forward only\)

## feature branch

* Where unfinished features live
* Feature branches can only be merged into develop branch

## fix branch

* Where unfinished fixes live
* Format `fix/{name of fix|issue no}` for example `fix/faulty-widget` or `fix/issue-123`
* Fix branches can be merged into release or develop branch\(es\)

```text
  develop
     |
-- ( A )
  \
   ------
```

