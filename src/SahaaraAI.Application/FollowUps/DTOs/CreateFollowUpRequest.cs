namespace SahaaraAI.Application.FollowUps.DTOs;

public class CreateFollowUpRequestDTO
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public Guid? OutreachMessageId { get; set; }
    public DateTime DueDate { get; set; }
    public string? Notes { get; set; }
    public string? GeneratedMessage { get; set; }
}
