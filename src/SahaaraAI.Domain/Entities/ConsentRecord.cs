using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;
using SahaaraAI.Domain;
using SahaaraAI.Infrastructure.Persistence;

namespace SahaaraAI.Domain.Entities;

public class ConsentRecord : AuditableEntity
{
    public Guid ApplicantId { get; set; }
    public Applicant? Applicant { get; set; }
    public ConsentStatus Status { get; set; }
    public string ConsentText { get; set; }
    public string? Notes { get; set; }
    public DateTime RecordedAt { get; set; }
    public Guid RecordedByUserId { get; set; }

    // Navigation
    public virtual ApplicationUser? RecordedByUser { get; set; }
}