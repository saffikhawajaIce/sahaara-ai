using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Applicants.DTOs;

public class ApplicantListItemDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public ConsentStatus ConsentStatus { get; set; }
    public DateTime CreatedAt { get; set; }
}
