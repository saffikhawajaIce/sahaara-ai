namespace SahaaraAI.Application.AI.DTOs;

public class AnalyzeCaseRequestDTO
{
    public Guid CaseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string RawDescription { get; set; } = string.Empty;
    public string? RequiredHelp { get; set; }
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
}
