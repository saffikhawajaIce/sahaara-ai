namespace SahaaraAI.Application.FollowUps.DTOs;

public class CreateFollowUpResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public FollowUpDto? FollowUp { get; set; }
}
