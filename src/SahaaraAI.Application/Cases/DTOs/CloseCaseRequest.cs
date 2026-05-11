namespace SahaaraAI.Application.Cases.DTOs;

public class CloseCaseRequestDTO
{
    public string ClosingReason { get; set; } = string.Empty;
    public string? FinalOutcome { get; set; }
}
