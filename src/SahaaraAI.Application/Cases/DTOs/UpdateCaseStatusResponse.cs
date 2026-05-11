namespace SahaaraAI.Application.Cases.DTOs;

public class UpdateCaseStatusResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public AssistanceCaseDto? Case { get; set; }
}
