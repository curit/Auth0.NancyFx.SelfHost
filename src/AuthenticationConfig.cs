namespace Nancy.Auth0
{
    public class AuthenticationConfig
    {
        public string RedirectOnLoginFailed { get; set; }
        public string CookieName { get; set; }
        public string UserIdentifier { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Domain { get; set; }
        public string CallbackUrl { get; set; }
    }
}