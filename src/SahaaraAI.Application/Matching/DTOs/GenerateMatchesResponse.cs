namespace SahaaraAI.Application.Matching.DTOs;

public class GenerateMatchesResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public MatchResultDto? Result { get; set; }
}
