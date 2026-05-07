using SahaaraAI.Domain.Common;
namespace SahaaraAI.Domain.Entities;

public class AssistanceCategory : AuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}