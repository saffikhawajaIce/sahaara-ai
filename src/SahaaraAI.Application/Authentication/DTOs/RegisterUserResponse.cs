namespace SahaaraAI.Application.Authentication.DTOs;

public class RegisterUserResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public string UserId { get; set; }
    public string Email { get; set; }
}

