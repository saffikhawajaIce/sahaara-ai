using SahaaraAI.Domain.Common;

namespace SahaaraAI.Domain.Entities;

public class CaseNgoMatch : AuditableEntity
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public int MatchScore { get; set; }
    public int Rank { get; set; }
    public string MatchReason { get; set; }
    public bool IsSelectedForOutreach { get; set; }
    public bool IsLatest { get; set; }

    // // Navigation properties
    public AssistanceCase Case { get; set; }
    public Ngo Ngo { get; set; }
}
