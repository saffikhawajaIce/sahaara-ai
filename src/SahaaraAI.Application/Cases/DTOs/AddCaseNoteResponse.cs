namespace SahaaraAI.Application.Cases.DTOs;

public class AddCaseNoteResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public CaseNoteDto? Note { get; set; }
}
