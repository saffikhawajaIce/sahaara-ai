namespace SahaaraAI.Application.Outreach.DTOs;

public class CreateOutreachDraftResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public OutreachMessageDto? Outreach { get; set; }
}
