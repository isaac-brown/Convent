# Version

{% api-method method="get" host="https://convent.io" path="/api/version" %}
{% api-method-summary %}
Get version
{% endapi-method-summary %}

{% api-method-description %}
Get version information.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
Version successfully retrieved.
{% endapi-method-response-example-description %}

```
{
    "applicationVersion": "x.y.z{-optional-tag}",
    "dotnetVersion": "X.Y.Z"
}
```
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}



