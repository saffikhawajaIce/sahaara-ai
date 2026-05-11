namespace SahaaraAI.Application.Communications.DTOs;

public class AddCommunicationLogResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public CommunicationLogDto? Log { get; set; }
}
