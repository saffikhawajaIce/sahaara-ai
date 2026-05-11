namespace SahaaraAI.Application.Applicants.DTOs;

public class UpdateConsentRequestDTO
{
    public int Id { get; set; }
    public bool ConsentGiven { get; set; }
    public string ConsentType { get; set; } = string.Empty;
    public DateTime ConsentDate { get; set; }
    public string Notes { get; set; } = string.Empty;
}
