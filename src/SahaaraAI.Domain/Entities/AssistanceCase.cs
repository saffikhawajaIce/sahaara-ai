using SahaaraAI.Domain.Common;
using SahaaraAI.Infrastructure.Persistence;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Domain.Entities;

public class AssistanceCase : AuditableEntity
{
    public Guid ApplicantId { get; set; }
    public Applicant? Applicant { get; set; }
    public string Title { get; set; }
    public string RawDescription { get; set; }
    public string? RequiredHelp { get; set; }
    public string City { get; set; }
    public string Area { get; set; }
    public CaseUrgency Urgency { get; set; }
    public CaseStatus Status { get; set; }
    public Guid CreatedByUserId { get; set; }
    public Guid? CategoryId { get; set; }
    public AssistanceCategory? Category { get; set; }
    public Guid? SubcategoryId { get; set; }
    public AssistanceSubcategory? Subcategory { get; set; }
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

    // Navigation
    // public virtual ICollection<CaseNote> Notes { get; set; }
    // public virtual ICollection<CaseNgoMatch> NgoMatches { get; set; }
    // public virtual ICollection<OutreachMessage> OutreachMessages { get; set; }
}