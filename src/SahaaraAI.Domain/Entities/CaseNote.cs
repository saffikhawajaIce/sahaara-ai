using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;
using SahaaraAI.Infrastructure.Persistence;

namespace SahaaraAI.Domain.Entities;

public class CaseNote : AuditableEntity
{
    public Guid CaseId { get; set; }
    public AssistanceCase? Case { get; set; }
    public Guid UserId { get; set; }
    public string Note { get; set; }
    public bool IsInternalOnly { get; set; }

    // Navigation
    public virtual ApplicationUser? User { get; set; }
}