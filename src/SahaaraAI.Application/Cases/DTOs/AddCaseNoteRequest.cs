namespace SahaaraAI.Application.Cases.DTOs;

public class AddCaseNoteRequestDTO
{
    public Guid UserId { get; set; }
    public string Note { get; set; } = string.Empty;
    public bool IsInternalOnly { get; set; }
}
