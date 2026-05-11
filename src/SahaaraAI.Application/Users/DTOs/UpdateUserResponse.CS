namespace SahaaraAI.Application.Users.DTOs;

public class UpdateUserResponseDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}
