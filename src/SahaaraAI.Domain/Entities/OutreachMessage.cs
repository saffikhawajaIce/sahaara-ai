using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Domain.Entities;

public class OutreachMessage : AuditableEntity
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public OutreachStatus Status { get; set; }
    public string? Subject { get; set; }
    public string Body { get; set; }
    public bool IsAiGenerated { get; set; }
    public bool IsApproved { get; set; }
    public Guid? ApprovedByUserId { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public DateTime? SentAt { get; set; }
    public DateTime? ResponseReceivedAt { get; set; }
    public string? FailureReason { get; set; }

    // Navigation Properties
    public virtual AssistanceCase Case { get; set; }
    public virtual Ngo Ngo { get; set; }
    public virtual ICollection<CommunicationLog> CommunicationLogs { get; set; } = new List<CommunicationLog>();
    public virtual ICollection<FollowUp> FollowUps { get; set; } = new List<FollowUp>();
}

