namespace SahaaraAI.Application.Cases.DTOs;

public class SearchCasesResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<CaseListItemDto> Cases { get; set; } = [];
}
