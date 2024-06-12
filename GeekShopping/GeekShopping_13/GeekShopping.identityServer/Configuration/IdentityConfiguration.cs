using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace GeekShopping.identityServer.Configuration
{
    public static class IdentityConfiguration
    {
        public const string Admin = "Admin";
        public const string Client = "Client";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()

            };

        public static IEnumerable<ApiScope> ApiScope =>
            new List<ApiScope>
            {
                new ApiScope("geek_shopping", "GeekShopping Server"),
                new ApiScope("read", "Read data."),
                new ApiScope("write", "Write data."),
                new ApiScope("delete", "delete data."),
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                 new Client
                 {
                     ClientId = "client",
                     ClientSecrets =
                     {
                         new Secret("my_super_secret".Sha256())
                     },
                     AllowedGrantTypes = GrantTypes.ClientCredentials,
                     AllowedScopes = {"read", "write", "profile"}
                 },
                                  new Client
                 {
                     ClientId = "geek_shopping",
                     ClientSecrets =
                     {
                         new Secret("my_super_secret".Sha256())
                     },
                     AllowedGrantTypes = GrantTypes.Code,
                     RedirectUris = {"https://localhost:4430/signin-oidc"},
                     PostLogoutRedirectUris = {"https://localhost:4430/signout-calback-oidc"},
                     AllowedScopes = new List<string>
                     {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile,
                         IdentityServerConstants.StandardScopes.Email,
                         "geek_shopping"
                     }
                 },
            };
    }
}
