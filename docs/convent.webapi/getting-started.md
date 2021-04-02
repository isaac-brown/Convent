---
description: Learn how to get started with Convent Web API.
---

# Getting started

If you want to consume an existing instance of of the Convent Web API then start with the [API documentation](api-documentation/).

If you want to look at the source then you can clone the Convent repository.

{% tabs %}
{% tab title="HTTPS" %}
```bash
git clone https://github.com/isaac-brown/Convent.git
```
{% endtab %}

{% tab title="SSH" %}
```
git@github.com:isaac-brown/Convent.git
```
{% endtab %}
{% endtabs %}

Once you have the source, navigate to the `src/Convent.WebApi` folder, then build and run it locally by using the .Net CLI.

```bash
cd src/Convent.WebAPI
dotnet run
```

The service will be running locally at `http://localhost:5000` or `https://localhost:5001` by default.

