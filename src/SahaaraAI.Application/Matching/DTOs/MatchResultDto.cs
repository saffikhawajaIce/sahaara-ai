namespace SahaaraAI.Application.Matching.DTOs;

public class MatchResultDto
{
    public Guid CaseId { get; set; }
    public int TotalCount { get; set; }
    public List<CaseNgoMatchDto> Matches { get; set; } = [];
}
