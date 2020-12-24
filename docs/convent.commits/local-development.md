---
description: Learn how to work with Convent.Commits locally.
---

# Local development

This guide assumes you want to work with Convent.Commits source code. Maybe you want to see how things tick by running the source yourself, or perhaps you have some nefarious purpose.

## Pre-requisites

Before starting with Convent.Commits locally you'll need to have the following installed:

* [.Net Core 3.1 Software Development Kit \(SDK\)](https://dotnet.microsoft.com/download/dotnet-core/3.1)

It's also **recommended** that you have the following available locally:

* [Git](https://git-scm.com/)
* An integrated development environment \(IDE\). You can use Visual Studio Code, Visual Studio IDE or any IDE which supports .Net development.

## Clone the source

Before you can muck around with the source locally, it needs to exist locally. To obtain the source use one of the following commands.

{% tabs %}
{% tab title="HTTPS" %}
```bash
git clone https://github.com/isaac-brown/Convent.Commits.git
```
{% endtab %}

{% tab title="SSH" %}
```
git clone git@github.com:isaac-brown/Convent.Commits.git
```
{% endtab %}

{% tab title="Curl - Zip" %}
```
curl -LJO https://github.com/isaac-brown/Convent/archive/master.zip
```
{% endtab %}
{% endtabs %}

## Building the source

Source can be built using the `dotnet` CLI.

```bash
dotnet build
```

Otherwise your favourite IDE should have a build command you can run.

## Running tests

Tests can be run using the `dotnet` CLI.

```bash
dotnet test
```

Otherwise your favourite IDE should have a test command you can run.

