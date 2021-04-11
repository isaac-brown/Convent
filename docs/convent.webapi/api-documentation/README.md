---
description: Explore the Convent web API documentation.
---

# API documentation

This chapter contains the current version \(v1\) of the Convent web API documentation.

{% api-method method="get" host="https://convent.io" path="/api" %}
{% api-method-summary %}
Get description
{% endapi-method-summary %}

{% api-method-description %}
Describes the API resource and it's related resources.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
Describes this resource and related resources.
{% endapi-method-response-example-description %}

```javascript
{
    "_links": [
        {
            "href": "https://convent.io/api",
            "rel": "self",
            "method": "GET"
        },
        {
            "href": "https://convent.io/api/v1",
            "rel": "version_1",
            "method": "GET"
        }
    ]
}
```
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}

