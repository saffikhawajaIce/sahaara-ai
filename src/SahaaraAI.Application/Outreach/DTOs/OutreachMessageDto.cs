using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Outreach.DTOs;

public class OutreachMessageDto
{
    public Guid Id { get; set; }
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public OutreachStatus Status { get; set; }
    public string? Subject { get; set; }
    public string Body { get; set; } = string.Empty;
    public bool IsAiGenerated { get; set; }
    public bool IsApproved { get; set; }
    public Guid? ApprovedByUserId { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public DateTime? SentAt { get; set; }
    public DateTime? ResponseReceivedAt { get; set; }
    public string? FailureReason { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
