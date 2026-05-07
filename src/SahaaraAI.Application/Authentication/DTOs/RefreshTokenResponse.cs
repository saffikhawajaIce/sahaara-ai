namespace SahaaraAI.Application.Authentication.DTOs
{
    public class RefreshTokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiresIn { get; set; }
        public string TokenType { get; set; } = "Bearer";
    }
}
