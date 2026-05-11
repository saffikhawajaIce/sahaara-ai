namespace SahaaraAI.Application.Matching.DTOs;

public class SelectNgoForOutreachResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
}
