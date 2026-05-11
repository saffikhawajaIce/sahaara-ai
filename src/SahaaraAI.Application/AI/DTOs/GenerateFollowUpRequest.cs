namespace SahaaraAI.Application.AI.DTOs;

public class GenerateFollowUpRequestDTO
{
    public Guid OutreachMessageId { get; set; }
    public string? PreviousMessageBody { get; set; }
    public string? LastResponseSummary { get; set; }
    public string? AdditionalInstructions { get; set; }
}
