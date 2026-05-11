namespace SahaaraAI.Application.FollowUps.DTOs;

public class CancelFollowUpResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public Guid FollowUpId { get; set; }
}
