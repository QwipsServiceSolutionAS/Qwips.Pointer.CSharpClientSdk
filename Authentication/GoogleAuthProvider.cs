using Google.Apis.Auth.OAuth2;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace PointerClientSDK.Authentication
{

    public class GoogleAuthorizationProvider : IAuthenticationProvider
    {
        private string _pointerAppScope { get; set; }
        private GoogleCredential googleCredential;

        public GoogleAuthorizationProvider(string fileName, string scope = "32555940559.apps.googleusercontent.com")
        {
            googleCredential = GoogleCredential.FromFile(fileName);
            _pointerAppScope = scope;
        }
        public GoogleAuthorizationProvider(Stream file, string scope = "32555940559.apps.googleusercontent.com")
        {
            googleCredential = GoogleCredential.FromStream(file);
            _pointerAppScope = scope;
        }
        public async Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
        {
            var token = await googleCredential.CreateScoped(_pointerAppScope).UnderlyingCredential.GetAccessTokenForRequestAsync();
            var headers = new RequestHeaders
            {
                { "Authorization", "Bearer " + token }
            };
            request.AddHeaders(headers);
        }
    }

}
