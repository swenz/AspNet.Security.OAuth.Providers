/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.Buffer
{
    /// <summary>
    /// Defines a set of options used by <see cref="BufferAuthenticationHandler"/>.
    /// </summary>
    public class BufferAuthenticationOptions : OAuthOptions
    {
        public BufferAuthenticationOptions()
        {
            AuthenticationScheme = BufferAuthenticationDefaults.AuthenticationScheme;
            DisplayName = BufferAuthenticationDefaults.DisplayName;
            ClaimsIssuer = BufferAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(BufferAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = BufferAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = BufferAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = BufferAuthenticationDefaults.UserInformationEndpoint;
        }
    }
}
