using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Outreach.DTOs;

public class SendOutreachRequestDTO
{
    public CommunicationChannel Channel { get; set; }
    public DateTime? SentAt { get; set; }
    public string? Notes { get; set; }
}
