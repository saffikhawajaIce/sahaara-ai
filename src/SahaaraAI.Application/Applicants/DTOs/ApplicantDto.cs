using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Applicants.DTOs;

public class ApplicantDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Cnic { get; set; }
    public string? Gender { get; set; }
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public string? AddressLine { get; set; }
    public int? FamilySize { get; set; }
    public decimal? MonthlyIncome { get; set; }
    public string? Occupation { get; set; }
    public string? Notes { get; set; }
    public ConsentStatus ConsentStatus { get; set; }
    public DateTime? ConsentRecordedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<ConsentRecordDto> ConsentRecords { get; set; } = [];
}
