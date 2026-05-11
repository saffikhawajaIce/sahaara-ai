using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.FollowUps.DTOs;

public class FollowUpSearchRequestDTO
{
    public Guid? CaseId { get; set; }
    public Guid? NgoId { get; set; }
    public DateTime? DueBefore { get; set; }
    public DateTime? DueAfter { get; set; }
    public FollowUpStatus? Status { get; set; }
}
