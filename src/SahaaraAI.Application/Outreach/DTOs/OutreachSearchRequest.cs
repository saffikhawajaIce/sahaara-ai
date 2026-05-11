using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Outreach.DTOs;

public class OutreachSearchRequestDTO
{
    public Guid? CaseId { get; set; }
    public Guid? NgoId { get; set; }
    public CommunicationChannel? Channel { get; set; }
    public OutreachStatus? Status { get; set; }
}
