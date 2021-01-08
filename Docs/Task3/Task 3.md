### Get User

`GET` api/Account/UserInfo

**Return**:

- User Info View Model

**Response(s)**:
- HTTP **204 No Content**



`POST` api/Account/Logout

**Response(s)**:
- HTTP **200 Ok**



`GET` api/Account/ManageInfo?returnUrl=%2F&generateState=true

**Return**:
- ManageInfoViewModel object




`POST` api/Account/ChangePassword

**Arguments(s)**:

| Argument | Type | Rule(s) | Description |
| - | - | - | - |
| OldPassword | `string` | At least 6 characters, contain a special character | Current password |
| NewPassword | `string` | At least 6 characters, contain a special character | New password |
| ConfirmPassword | `string` | Same as NewPassword | Confirm new password |





`POST` api/Account/SetPassword
| Argument | Type | Rule(s) | Description |
| - | - | - | - |
| NewPassword | `string` | At least 6 characters, contain a special character | New password |
| ConfirmPassword | `string` | Same as NewPassword | Confirm new password |

**Return**:

- HTTP **200 Ok**


**Error(s)**:

| Type | Code | Description |
| invalid_request | 400 | Password does not meet requirements |




`POST` api/Account/AddExternalLogin

**Arguments(s)**:
| Argument | Description |
| - | - |
| ExternalAccessToken | Access Token |


**Return**:
- HTTP **200 Ok**


**Error(s)**:

| Type | Code | Description |
| - | - | - |
| invalid_model_state | 400 | Model State is not found |
| no_external_data | 400 | external login already used |
| invalid_Authentication_ticket | 400 | Access Token Expire |




`POST` api/Account/RemoveLogin

**Arguments(s)**:
| Argument | Rule(s) | Description |
| - | - | - |
| LoginProvider | Required | login provider |
| ProviderKey | Required | provider key |

**Return**:
- HTTP **200 Ok**

**Error(s)**:
| Type | Code | Description |
| - | - | - |
| invalid_model_state | 400 | Model State is not found | 




`GET` api/Account/ExternalLogin

**Return**: 
- ChallengeResult

**Response(s)**:
- HTTP **200 Ok**




`GET` api/Account/ExternalLogins?returnUrl=%2F&generateState=true

**Return**:
- List of Logins




`POST` api/Account/Register
| Argument | Type | Rule(s) | Description |
| - | - | - | - |
| Email | `string` | Required | email |
| Password | `string` | Required | password |
| ConfirmPassword | `string` | Same as password | confirm password |


**Response(s)**:
- HTTP **200 Ok**

**Error(s)**:
| Type | Code | Description |
| - | - | - |
| invalid model state | 400 | Model State is not found |




`GET` api/Account/Verify

**Return**: 
- Token string



`POST` api/Account/Verify
| Argument | Description |
| - | - |
| Token | token |
| secret | secret key |




`POST` api/Account/RegisterExternal
| Argument | Type | Rule(s) | Description |
| - | - | - | - |
| Email | `string` | Required | email |
| Password | `string` | Required | password |
| ConfirmPassword | `string` | Same as password | confirm password |









