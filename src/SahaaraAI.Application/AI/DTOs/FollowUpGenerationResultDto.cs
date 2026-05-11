namespace SahaaraAI.Application.AI.DTOs;

public class FollowUpGenerationResultDto
{
    public string Message { get; set; } = string.Empty;
    public DateTime? SuggestedSendAt { get; set; }
    public List<string> Flags { get; set; } = [];
}
