using SahaaraAI.Domain.Common;

namespace SahaaraAI.Domain.Entities;

public class AssistanceCategory : AuditableEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public int SortOrder { get; set; }

    // Navigation properties
    public ICollection<AssistanceSubcategory> Subcategories { get; set; } = new List<AssistanceSubcategory>();
    public ICollection<NgoService> NgoServices { get; set; } = new List<NgoService>();
}
