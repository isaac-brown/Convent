---
description: Provides services for working with commit messages.
---

# Commits

{% api-method method="post" host="https://convent.io" path="/api/v1/commits/feature" %}
{% api-method-summary %}
Create a feature commit
{% endapi-method-summary %}

{% api-method-description %}
Creates a feature commit message.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}
{% api-method-headers %}
{% api-method-parameter name="Content-Type" type="string" required=false %}
Should always be `application/json`.
{% endapi-method-parameter %}
{% endapi-method-headers %}

{% api-method-body-parameters %}
{% api-method-parameter name="hasScope" type="boolean" required=false %}
Indicates whether or not a scope should be included. Default is `false`.
{% endapi-method-parameter %}

{% api-method-parameter name="hasBody" type="boolean" required=false %}
Indicates whether or not a body should be included. Default is `false`.
{% endapi-method-parameter %}

{% api-method-parameter name="hasIssue" type="boolean" required=false %}
Indicates whether or not an issue should be included. Default is `false`.
{% endapi-method-parameter %}

{% api-method-parameter name="hasBreakingChange" type="boolean" required=false %}
Indicates whether or not a breaking change should be included. Default is `false`.
{% endapi-method-parameter %}
{% endapi-method-body-parameters %}
{% endapi-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
Everything went well.
{% endapi-method-response-example-description %}

```javascript
{
    "message": "feat: payment green sensor"
}
```
{% endapi-method-response-example %}

{% api-method-response-example httpCode=400 %}
{% api-method-response-example-description %}
The request body was malformed and could not be processed.
{% endapi-method-response-example-description %}

{% tabs %}
{% tab title="Missing body" %}
```javascript
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "|b78e5747-4cc31f6e3e296139.",
  "errors": { "": ["A non-empty request body is required."] }
}
```
{% endtab %}

{% tab title="Malformed body" %}
```javascript
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "|b78e5749-4cc31f6e3e296139.",
  "errors": {
    "$.hasScope": [
      "The JSON value could not be converted to System.Boolean. Path: $.hasScope | LineNumber: 0 | BytePositionInLine: 27."
    ]
  }
}
```
{% endtab %}
{% endtabs %}
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}

{% api-method method="post" host="https://convent.io" path="/api/v1/commits/fix" %}
{% api-method-summary %}
Create a fix commit
{% endapi-method-summary %}

{% api-method-description %}
Creates a fix commit message.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}
{% api-method-headers %}
{% api-method-parameter name="Content-Type" type="string" required=false %}
Should always be `application/json`.
{% endapi-method-parameter %}
{% endapi-method-headers %}

{% api-method-body-parameters %}
{% api-method-parameter name="hasScope" type="boolean" required=false %}
Indicates whether or not a scope should be included. Default is `false`.
{% endapi-method-parameter %}

{% api-method-parameter name="hasBody" type="boolean" required=false %}
Indicates whether or not a body should be included. Default is `false`.
{% endapi-method-parameter %}

{% api-method-parameter name="hasIssue" type="boolean" required=false %}
Indicates whether or not an issue should be included. Default is `false`.
{% endapi-method-parameter %}

{% api-method-parameter name="hasBreakingChange" type="boolean" required=false %}
Indicates whether or not a breaking change should be included. Default is `false`.
{% endapi-method-parameter %}
{% endapi-method-body-parameters %}
{% endapi-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
Everything went well.
{% endapi-method-response-example-description %}

```javascript
{
    "message": "fix: Kansas down-sized"
}
```
{% endapi-method-response-example %}

{% api-method-response-example httpCode=400 %}
{% api-method-response-example-description %}
The request message was malformed and could not be processed.
{% endapi-method-response-example-description %}

{% tabs %}
{% tab title="Missing body" %}
```javascript
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "|b78e5747-4cc31f6e3e296139.",
  "errors": { "": ["A non-empty request body is required."] }
}
```
{% endtab %}

{% tab title="Malformed body" %}
```javascript
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "|b78e5749-4cc31f6e3e296139.",
  "errors": {
    "$.hasScope": [
      "The JSON value could not be converted to System.Boolean. Path: $.hasScope | LineNumber: 0 | BytePositionInLine: 27."
    ]
  }
}
```
{% endtab %}
{% endtabs %}
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}

{% api-method method="post" host="https://convent.io" path="/api/v1/commits/chore" %}
{% api-method-summary %}
Create a chore commit
{% endapi-method-summary %}

{% api-method-description %}
Creates a chore commit message.
{% endapi-method-description %}

{% api-method-spec %}
{% api-method-request %}
{% api-method-headers %}
{% api-method-parameter name="" type="string" required=false %}
Should always be `application/json`.
{% endapi-method-parameter %}
{% endapi-method-headers %}

{% api-method-body-parameters %}
{% api-method-parameter name="" type="string" required=false %}

{% endapi-method-parameter %}

{% api-method-parameter name="" type="string" required=false %}

{% endapi-method-parameter %}

{% api-method-parameter name="" type="string" required=false %}

{% endapi-method-parameter %}

{% api-method-parameter name="hasScope" type="boolean" required=false %}

{% endapi-method-parameter %}
{% endapi-method-body-parameters %}
{% endapi-method-request %}

{% api-method-response %}
{% api-method-response-example httpCode=200 %}
{% api-method-response-example-description %}
Everything went well.
{% endapi-method-response-example-description %}

```javascript
{
    "message": "chore: innovative orchestrator interactions"
}
```
{% endapi-method-response-example %}

{% api-method-response-example httpCode=400 %}
{% api-method-response-example-description %}
The request body was malformed and could not be processed.
{% endapi-method-response-example-description %}

{% tabs %}
{% tab title="Missing body" %}
```javascript
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "|b78e5747-4cc31f6e3e296139.",
  "errors": { "": ["A non-empty request body is required."] }
}
```
{% endtab %}

{% tab title="Malformed body" %}
```javascript
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "|b78e5749-4cc31f6e3e296139.",
  "errors": {
    "$.hasScope": [
      "The JSON value could not be converted to System.Boolean. Path: $.hasScope | LineNumber: 0 | BytePositionInLine: 27."
    ]
  }
}
```
{% endtab %}
{% endtabs %}
{% endapi-method-response-example %}
{% endapi-method-response %}
{% endapi-method-spec %}
{% endapi-method %}

