using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Communications.DTOs;

public class CommunicationLogDto
{
    public Guid Id { get; set; }
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public Guid? OutreachMessageId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public string Action { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public DateTime OccurredAt { get; set; }
    public Guid PerformedByUserId { get; set; }
    public string? ResponseStatus { get; set; }
    public string? ResponseNotes { get; set; }
    public string? SupportOffered { get; set; }
    public string? DocumentsRequested { get; set; }
    public string? ReferralDetails { get; set; }
    public DateTime? NextFollowUpDate { get; set; }
}
