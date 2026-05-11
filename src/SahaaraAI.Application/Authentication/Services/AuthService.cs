using SahaaraAI.Application.Authentication.DTOs;

namespace SahaaraAI.Application.Authentication.Services;

public class AuthService : IAuthService
{
    public Task<LoginResponse> LoginAsync(LoginRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request)
    {
        throw new NotImplementedException();
    }
}
