using SahaaraAI.Domain.Common;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Domain.Entities;

public class Ngo : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public string? AddressLine { get; set; }
    public string? Website { get; set; }
    public string? PreferredContactMethod { get; set; }
    public string? EligibilityNotes { get; set; }
    public string? RequiredDocuments { get; set; }
    public string? OfficeHours { get; set; }
    public NgoStatus Status { get; set; }
    public bool IsActive { get; set; }

    // Optional later
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

    // Navigation properties
    public ICollection<NgoService> Services { get; set; } = new List<NgoService>();
    public ICollection<CaseNgoMatch> CaseMatches { get; set; } = new List<CaseNgoMatch>();
    public ICollection<OutreachMessage> OutreachMessages { get; set; } = new List<OutreachMessage>();
}
