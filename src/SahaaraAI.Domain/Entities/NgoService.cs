using SahaaraAI.Domain.Common;

namespace SahaaraAI.Domain.Entities;

public class NgoService : AuditableEntity
{
    public Guid NgoId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public string? Description { get; set; }
    public string? EligibilityNotes { get; set; }
    public bool IsActive { get; set; }

    // // Navigation properties
    public Ngo Ngo { get; set; } = null!;
    public AssistanceCategory Category { get; set; } = null!;
    public AssistanceSubcategory? Subcategory { get; set; }
}
