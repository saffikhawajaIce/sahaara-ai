using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Domain.Entities;

public class FollowUp : AuditableEntity
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public Guid? OutreachMessageId { get; set; }
    public FollowUpStatus Status { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? CompletedAt { get; set; }
    public string? Notes { get; set; }
    public string? GeneratedMessage { get; set; }

    // Navigation properties
    public AssistanceCase Case { get; set; } = null!;
    public Ngo Ngo { get; set; } = null!;
    public OutreachMessage? OutreachMessage { get; set; }
}
