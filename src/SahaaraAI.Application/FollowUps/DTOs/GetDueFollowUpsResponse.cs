namespace SahaaraAI.Application.FollowUps.DTOs;

public class GetDueFollowUpsResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<FollowUpDto> FollowUps { get; set; } = [];
}
