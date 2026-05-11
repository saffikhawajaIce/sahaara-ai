namespace SahaaraAI.Application.Dashboard.DTOs;

public class RecentActivityDto
{
    public DateTime OccurredAt { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid? RelatedEntityId { get; set; }
}
