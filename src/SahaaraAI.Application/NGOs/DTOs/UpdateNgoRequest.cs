namespace SahaaraAI.Application.NGOs.DTOs;

public class UpdateNgoRequestDTO
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
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
}
