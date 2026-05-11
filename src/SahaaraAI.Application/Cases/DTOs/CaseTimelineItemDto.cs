namespace SahaaraAI.Application.Cases.DTOs;

public class CaseTimelineItemDto
{
    public DateTime OccurredAt { get; set; }
    public string EventType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}
