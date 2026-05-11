namespace SahaaraAI.Application.Cases.DTOs;

public class GetCaseResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public AssistanceCaseDto? Case { get; set; }
}
