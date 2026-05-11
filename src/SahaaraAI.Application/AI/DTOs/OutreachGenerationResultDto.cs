using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.AI.DTOs;

public class OutreachGenerationResultDto
{
    public string? Subject { get; set; }
    public string Body { get; set; } = string.Empty;
    public CommunicationChannel Channel { get; set; }
    public List<string> Flags { get; set; } = [];
}
