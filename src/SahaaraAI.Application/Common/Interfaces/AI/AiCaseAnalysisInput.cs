namespace SahaaraAI.Application.Common.Interfaces.AI;

public class AiCaseAnalysisInput
{
    public Guid CaseId { get; set; }
    public string Prompt { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string RawDescription { get; set; } = string.Empty;
    public string? RequiredHelp { get; set; }
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
}
