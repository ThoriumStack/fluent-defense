# Defensive Extensions

# Example Code

csharp```
public void EnableAuthentication(string tokenBaseUrl, string clientId, string clientSecret, string appName)
        {
            _tokenBaseUrl = tokenBaseUrl;

            // create global validator
            
            tokenBaseUrl
                .Defend(nameof(tokenBaseUrl))
                .ValidUri()
                .Throw();

            clientId
                .Defend(nameof(clientId))
                .NotNullOrEmpty()
                .Throw();

            clientSecret
                .Defend(nameof(clientSecret))
                .NotNullOrEmpty()
                .Throw();

            appName
                .Defend(nameof(appName))
                .NotNullOrEmpty()
                .Throw();

            _tokenAuthenticationCredentials = new TokenAuthenticationCredentials
            {
                AppName = appName,
                ClientId = clientId,
                ClientSecret = clientSecret
            };
        }
```