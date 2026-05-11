using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Cases.DTOs;

public class CaseListItemDto
{
    public Guid Id { get; set; }
    public Guid ApplicantId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public CaseUrgency Urgency { get; set; }
    public CaseStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
}
