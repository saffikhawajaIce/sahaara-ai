namespace SahaaraAI.Application.Cases.DTOs;

public class CaseNoteDto
{
    public Guid Id { get; set; }
    public Guid CaseId { get; set; }
    public Guid UserId { get; set; }
    public string Note { get; set; } = string.Empty;
    public bool IsInternalOnly { get; set; }
    public DateTime CreatedAt { get; set; }
}
