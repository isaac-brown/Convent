---
description: Guidance on extending the Convent.Commits package.
---

# Extending Convent.Commits

{% hint style="info" %}
Currently there is only support for extending the `CommitType` class. Other extensibility will be added over time.
{% endhint %}

## Extending CommitType

If you want to have access to move commit types that is provided by `CommitType` then you can do using the following steps.

1. Create your own class which implements `CommitType`
2. Add your own static properties which return `CommitType`
3. Use your implementation.

### Add an additional commit type 

Say you want to add your own commit type of `docs`  which will represent a commit which relates to documentation for the repository. First, create your own class `CustomCommitType` which extends `CommitType`.

```csharp
public class CustomCommitType : CommitType
{
    private CustomCommitType(string name)
        : base(name)
    { }
}
```

Now add your own static property called `Documentation` which will represents our desired `CommitType`.

```csharp
public class CustomCommitType : CommitType
{
    public static CommitType Documentation => new CustomCommitType(name: "docs");
    
    // ...
}
```

Now you can use `CustomCommitType.Documentation`  to create commit messages with the prefix `docs`.

```csharp
var commitFactory = new ConventionalCommitMessageFactory();

var message = commitFactory.CreateCommitMessage(CustomCommitType.Documentation);

Console.WriteLine(message);

// Result: docs: innovative orchestrator interactions
```

Full source of the `CustomCommitType` class can be found below:

{% code title="CustomCommitType.cs" %}
```csharp
using Convent.Commits;

namespace Your.Project
{
    public static CommitType Documentation => new CustomCommitType(name: "docs");

    public class CustomCommitType : CommitType
    {
        private CustomCommitType(string name)
            : base(name)
        { }
    }
}
```
{% endcode %}

