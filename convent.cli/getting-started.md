---
description: Learn how to get started with the Convent CLI.
---

# Getting started

{% hint style="warning" %}
### This page is still under construction.
{% endhint %}

```bash
# ==========
# Get help.
convent-cli --help


# =====================
# Display the version.
convent-cli --version


# =================================
# Create a feature commit message.
> convent-cli feature

feat: payment green sensor


# =============================
# Create a fix commit message.
> convent-cli fix

fix: Kansas down-sized


# ===============================
# Create a chore commit message.
> convent-cli chore

chore: innovative orchestrator interactions


# ===================
# Providing options.
$ convent-cli --scope \
>             --body \
>             --issue \
>             --breaking-change

# Or using aliases:
$ convent-cli -sbi --breaking-change

feat(games): licensed extension RAM
Tasty New York
Closes #2733
BREAKING CHANGE: Music
```

