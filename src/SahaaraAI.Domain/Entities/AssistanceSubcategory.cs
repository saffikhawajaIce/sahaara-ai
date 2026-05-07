using SahaaraAI.Domain.Common;
namespace SahaaraAI.Domain.Entities;

public class AssistanceSubcategory : AuditableEntity
{
    public Guid AssistanceCategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation property
    public virtual AssistanceCategory AssistanceCategory { get; set; }
}