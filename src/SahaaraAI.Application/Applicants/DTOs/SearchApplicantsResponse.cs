namespace SahaaraAI.Application.Applicants.DTOs;

public class SearchApplicantsResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<ApplicantListItemDto> Applicants { get; set; } = [];
}
