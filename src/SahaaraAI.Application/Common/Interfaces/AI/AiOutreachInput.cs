using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Common.Interfaces.AI;

public class AiOutreachInput
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public string Prompt { get; set; } = string.Empty;
    public string? AdditionalInstructions { get; set; }
}
