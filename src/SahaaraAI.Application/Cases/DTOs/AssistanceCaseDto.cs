using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Cases.DTOs;

public class AssistanceCaseDto
{
    public Guid Id { get; set; }
    public Guid ApplicantId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string RawDescription { get; set; } = string.Empty;
    public string? RequiredHelp { get; set; }
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public CaseUrgency Urgency { get; set; }
    public CaseStatus Status { get; set; }
    public Guid CreatedByUserId { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public string? AiSummary { get; set; }
    public string? RequiredSupportJson { get; set; }
    public string? SuggestedDocumentsJson { get; set; }
    public string? SensitivityLevel { get; set; }
    public AiReviewStatus AiReviewStatus { get; set; }
    public DateTime? AiAnalyzedAt { get; set; }
    public Guid? AiReviewedByUserId { get; set; }
    public DateTime? AiReviewedAt { get; set; }
    public string? ClosingReason { get; set; }
    public string? FinalOutcome { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<CaseNoteDto> Notes { get; set; } = [];
    public List<CaseTimelineItemDto> Timeline { get; set; } = [];
}
