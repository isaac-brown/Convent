---
description: Version 1 of the web API.
---

# V1

{% api-method method="get" host="https://convent.io" path="/api/v1" %}
{% api-method-summary %}
Get description
{% endapi-method-summary %}

{% api-method-description %}
Describes the version 1 resource and it's related resources.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
A collections of links describing this resource and related resources.
{% endapi-method-response-example-description %}

```javascript
{
    "_links": [
        {
            "href": "https://convent.io/api/v1",
            "rel": "self",
            "method": "GET"
        },
        {
            "href": "https://convent.io/api",
            "rel": "parent",
            "method": "GET"
        },
        {
            "href": "https://convent.io/api/v1/commits",
            "rel": "commits",
            "method": "GET"
        }
    ]
}
```
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}

