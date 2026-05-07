namespace SahaaraAI.Domain.Common;

public abstract class SoftDeletableEntity
{
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted => DeletedAt.HasValue;

    public void Delete()
    {
        DeletedAt = DateTime.UtcNow;
    }

    public void Restore()
    {
        DeletedAt = null;
    }
}
