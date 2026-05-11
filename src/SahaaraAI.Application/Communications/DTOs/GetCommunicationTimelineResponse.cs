namespace SahaaraAI.Application.Communications.DTOs;

public class GetCommunicationTimelineResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public CommunicationTimelineDto? Timeline { get; set; }
}
