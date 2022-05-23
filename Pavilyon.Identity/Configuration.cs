using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pavilyon.Identity
{
    public class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("PavilyonWebAPI", "Web API")
            };
        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource("PavilyonWebAPI", "Web API", new []
                    { JwtClaimTypes.Name })
                {
                    Scopes = {"PavilyonWebAPI"}
                }
            };
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "pavilyon-web-api",
                    ClientName = "Pavilyon Web",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,
                    RequirePkce = true,
                    RedirectUris =
                    {
                        "http://localhost/signin-oidc"
                    },
                    AllowedCorsOrigins =
                    {
                        "http://localhost"
                    },
                    PostLogoutRedirectUris =
                    {
                        "http://localhost/signout-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "PavilyonWebAPI"
                    },
                    AllowAccessTokensViaBrowser = true
                }
            };
    }
}
