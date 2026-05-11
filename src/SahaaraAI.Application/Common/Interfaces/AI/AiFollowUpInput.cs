namespace SahaaraAI.Application.Common.Interfaces.AI;

public class AiFollowUpInput
{
    public Guid OutreachMessageId { get; set; }
    public string Prompt { get; set; } = string.Empty;
    public string? PreviousMessageBody { get; set; }
    public string? LastResponseSummary { get; set; }
}
