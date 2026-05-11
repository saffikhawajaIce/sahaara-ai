namespace SahaaraAI.Application.Communications.DTOs;

public class CommunicationTimelineDto
{
    public Guid CaseId { get; set; }
    public int TotalCount { get; set; }
    public List<CommunicationLogDto> Logs { get; set; } = [];
}
