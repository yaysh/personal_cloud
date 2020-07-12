using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;

namespace backend
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name = "customAPI",
                    DisplayName = "API #1",
                    Description = "Allow the application to access API #1 on your behalf",
                    Scopes = new List<string> {"api1.read", "api1.write"},
                    ApiSecrets = new List<Secret> {new Secret("ScopeSecret".Sha256())},
                    UserClaims = new List<string> {"role"}
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client_id",
                    ClientName = "hello",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> {new Secret("SuperSecretPassword".ToSha256())},
                    AllowedScopes = new List<string> {"ApiOne.read"}
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string> {"role"}
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api1.read", "Read Access to API #1"),
                new ApiScope("api1.write", "Write Access to API #1")
            };  
        }

    }
}
