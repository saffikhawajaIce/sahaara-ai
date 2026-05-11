using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Audit.DTOs;

public class AuditSearchRequestDTO
{
    public Guid? UserId { get; set; }
    public string? EntityName { get; set; }
    public Guid? EntityId { get; set; }
    public AuditActionType? ActionType { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
