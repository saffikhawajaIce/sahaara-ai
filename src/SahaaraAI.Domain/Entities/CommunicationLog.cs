using System;
using System.Collections.Generic;
using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Domain.Entities;

public class CommunicationLog : AuditableEntity
{
    // Communication fields
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public Guid? OutreachMessageId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public string Action { get; set; }
    public string? Notes { get; set; }
    public DateTime OccurredAt { get; set; }
    public Guid PerformedByUserId { get; set; }

    // Response fields
    public string? ResponseStatus { get; set; }
    public string? ResponseNotes { get; set; }
    public string? SupportOffered { get; set; }
    public string? DocumentsRequested { get; set; }
    public string? ReferralDetails { get; set; }
    public DateTime? NextFollowUpDate { get; set; }

    // Navigation properties
    public virtual AssistanceCase Case { get; set; }
    public virtual Ngo Ngo { get; set; }
    public virtual OutreachMessage? OutreachMessage { get; set; }
}

