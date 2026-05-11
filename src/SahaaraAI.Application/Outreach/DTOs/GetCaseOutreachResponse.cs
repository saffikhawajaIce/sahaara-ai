namespace SahaaraAI.Application.Outreach.DTOs;

public class GetCaseOutreachResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<OutreachMessageDto> OutreachMessages { get; set; } = [];
}
