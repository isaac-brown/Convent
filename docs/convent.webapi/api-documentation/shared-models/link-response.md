# Link response

Represents a link to a resource.

## Properties

### href

The URL to the resource.

### rel

Describes the relation of the resource to the current resource.

### method

Describes the HTTP method used to request the resource.

## Example

The following example shows a link which describes the [Create a chore Commit resource](../v1/commits.md#create-a-chore-commit).

```javascript
{
    "href": "https://convent.io/api/v1/commits/chore",
    "rel": "create_chore_commit",
    "method": "POST"
}
```

