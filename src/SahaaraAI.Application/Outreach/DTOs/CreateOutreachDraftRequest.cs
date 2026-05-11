using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Outreach.DTOs;

public class CreateOutreachDraftRequestDTO
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public string? Subject { get; set; }
    public string Body { get; set; } = string.Empty;
    public bool IsAiGenerated { get; set; }
}
