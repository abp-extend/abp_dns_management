# abp_dns_management

Dns management abp console library module let you update cname record in cloudflare.

Before you use this module make sure you update the cloudflare token and zone id. You can create this in your cloudflare account

[Create Your Token](https://dash.cloudflare.com/profile/api-tokens) and [ZoneId & AccountId](https://developers.cloudflare.com/fundamentals/get-started/basic-tasks/find-account-and-zone-ids/)

### Setup

You must have this following inside appsettings.json

```json
{
	{
		"Cloudflare": {

			"Token": "{place your cloudflare token}",

			"ZoneId": "{place your cloudflare zone id}",

			"AccountId": "{place your cloudflare account id}"
		}
	}
	
}
```
