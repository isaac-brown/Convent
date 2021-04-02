---
description: Learn about the branching strategy employed across Convent repositories.
---

# Branching strategy

## master branch

* `master` is where merged features and fixes lives
* `master` is where releases are cut from
* The head of `master` is not guaranteed to be the latest version released, tags will indicate this

## feature branches

* Where unfinished features live
* Format `feature/{name of fix|issue no}` for example `feature/do-things` or `feature/issue-123`
* Feature branches can only be merged into develop branch
* Feature branches should be squashed while merging

### **Lifecycle**

1. `feature` create from `master`
2. `feature` do work
3. `master` merge with `feature` \(squash\)
4. `feature` delete

## fix branches

* Where unfinished fixes live
* Format `fix/{name of fix|issue no}` for example `fix/faulty-widget` or `fix/issue-123`
* Fix branches can be merged into release or develop branch\(es\)

### Lifecycle

1. `fix` create from `master`
2. `fix` do work
3. `master` merge with `fix` \(squash\)
4. `fix` delete

