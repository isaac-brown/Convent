---
description: Learn about the branching strategy employed across Convent repositories.
---

# Branching strategy

## master branch

* `master` is where merged [topics branches](branching-strategy.md#topic-branches) live
* `master` is where releases are cut from \(except for [hotfixes](branching-strategy.md#hotfix-branch)\)
* The head of `master` is not guaranteed to be the latest version released, tags will indicate this

## topic branches

* Where unfinished features, fixes and any other work lives
* Format is `{contributor}/{name of fix|issue no}` for example:
  * `isaac-brown/do-things` or
  * `isaac-brown/issue-123`
* Topic branches can only be merged into the `master` branch
* Topic branches should be squashed when merging

### **Lifecycle**

1. Create `topic` from `master`
2. Do work on `topic` branch
3. Raise pull request from `topic` to `master`
4. `topic` merge with `master` \(squash\)
5. Delete `topic`

## hotfix branch

* Where hotfixes to existing releases go
* A hotfix branch is only required when `master` has changes which have not been released

### Lifecycle

1. Create `hotfix` branch from affected tag
2. Create fix for issue
3. Cut release on `hotfix` branch
4. \(optional\) merge `hotfix` with `master` \(merge no fast forward\)
5. \(optional\) delete `hotfix` branch

