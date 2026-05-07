using SahaaraAI.Application.Authentication.DTOs;

namespace SahaaraAI.Application.Authentication.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request);
        Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request);
    }
}
