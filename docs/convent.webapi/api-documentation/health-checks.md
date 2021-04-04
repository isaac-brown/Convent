---
description: Learn how to check the health status of Convent.WebApi
---

# Health checks

{% api-method method="get" host="https://convent.io" path="/api/health" %}
{% api-method-summary %}
Health
{% endapi-method-summary %}

{% api-method-description %}
Checks the health of the API.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
Cake successfully retrieved.
{% endapi-method-response-example-description %}

```
Healthy
```
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}



