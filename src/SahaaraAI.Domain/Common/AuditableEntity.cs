namespace SahaaraAI.Domain.Common;

public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public Guid CreatedByUserID { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? UpdatedByUserID { get; set; }
}