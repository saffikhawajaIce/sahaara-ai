using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Domain.Entities;

public class AuditEntry : BaseEntity
{
    public Guid? UserId { get; set; }
    public string EntityName { get; set; } = string.Empty;
    public Guid? EntityId { get; set; }
    public AuditActionType ActionType { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public string? MetadataJson { get; set; }
}
