using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.AI.DTOs;

public class CaseAnalysisResultDto
{
    public string Summary { get; set; } = string.Empty;
    public string? RequiredSupportJson { get; set; }
    public string? SuggestedDocumentsJson { get; set; }
    public string? SensitivityLevel { get; set; }
    public AiReviewStatus ReviewStatus { get; set; }
    public DateTime? ReviewedAt { get; set; }
    public Guid? ReviewedByUserId { get; set; }
    public List<string> Flags { get; set; } = [];
}
