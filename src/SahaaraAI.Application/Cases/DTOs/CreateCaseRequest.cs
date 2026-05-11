using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Cases.DTOs;

public class CreateCaseRequestDTO
{
    public Guid ApplicantId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string RawDescription { get; set; } = string.Empty;
    public string? RequiredHelp { get; set; }
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public CaseUrgency Urgency { get; set; }
    public Guid CreatedByUserId { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
}
