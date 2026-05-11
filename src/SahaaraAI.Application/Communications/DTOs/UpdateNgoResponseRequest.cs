namespace SahaaraAI.Application.Communications.DTOs;

public class UpdateNgoResponseRequestDTO
{
    public string? ResponseStatus { get; set; }
    public string? ResponseNotes { get; set; }
    public string? SupportOffered { get; set; }
    public string? DocumentsRequested { get; set; }
    public string? ReferralDetails { get; set; }
    public DateTime? NextFollowUpDate { get; set; }
}
