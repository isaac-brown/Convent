---
description: Learn how to get started with the Convent.Commits package.
---

# Getting started

First add a reference to the Convent.Commits package in your project.

{% tabs %}
{% tab title="dotnet cli" %}
```
dotnet add package Convent.Commits
```
{% endtab %}

{% tab title="Package Manager Console" %}
```
Install-Package Convent.Commits
```
{% endtab %}
{% endtabs %}

Import the `Convent.Commits` namespace.

```csharp
using Convent.Commits;
```

Create a `ConventionalCommitMessageFactory` instance and then start using it. For example, to create a feature commit with default options:

```csharp
var commitFactory = new ConventionalCommitMessageFactory();

var message = commitFactory.CreateCommitMessage(CommitType.Feature);

Console.WriteLine(message);

// Result: feat: payment green sensor
```

You can also provide a `CommitMessageOptions` instance to add extra portions to commit message generated.

```csharp
var options =  new CommitMessageOptions
{
    HasScope = true,
    HasBody = true,
    HasIssue = true,
    HasBreakingChange = true,
};

// Equivalent to:
options = CommitMessageOptions.All;

commitFactory.CreateCommitMessage(CommitType.Feature, options);

// Result:
// feat(games): licensed extension RAM
// Tasty New York
// Closes #2733
// BREAKING CHANGE: Music
```

