namespace SahaaraAI.Application.Applicants.DTOs;

public class GetApplicantResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public ApplicantDto? Applicant { get; set; }
}
