using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.AI.DTOs;

public class GenerateOutreachRequestDTO
{
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public CommunicationChannel Channel { get; set; }
    public string? AdditionalInstructions { get; set; }
}
