namespace SahaaraAI.Application.Outreach.DTOs;

public class ApproveOutreachResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public OutreachMessageDto? Outreach { get; set; }
}
