#### Get Products

`GET` api/v3/products

**Return**:

- Array of products

**Response(s)**:

```json
{
	Id: int,
	Name: string,
	Category: string(100),
	Price: decimal
}
```



`GET` api/v3/products/{id:int:min(1)}

**Return**:

- Product Object

**Response(s)**:

```json
{
    Id: int,
	Name: string,
	Category: string(100),
	Price: decimal
}
```



`GET` api/v3/products, Name

**Return**:

- Array of products of the same category

**Response(s)**:

```json
{
    Id: int,
	Name: string,
	Category: string(100),
	Price: decimal
}
```



`POST` api/v3/products

**Argument(s)**:

| Argument | Type | Rule(s) | Description |
| - | - | - | - | 
| Name | `string` | Required | Name of `Product` |
| Category | `string` | length(0, 100), Required | Category of `Product` |
| Price | `decimal` | price | Price of `Product` |

**Return**:
- HTTP **201 Created**

**Error(s)**:
| Type | Code | Description |
| - | - | - |
| invalid_price | 400 | Price needs to be a number |
| invalid price | 400 | Redundant dollar sign added in price input |




`PUT` api/v3/products/{id:int}

**Description**
- Update the product with the new name, category and price

**Return**
- HTTP **204 No Content**



`DELETE` api/v3/products/{id:int}
** Description**
- Delete the product with using its Id

**Return**
- HTTP **204 No Content**



