using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Communications.DTOs;

public class AddCommunicationLogRequestDTO
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public Guid? OutreachMessageId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public string Action { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public DateTime OccurredAt { get; set; }
    public Guid PerformedByUserId { get; set; }
}
