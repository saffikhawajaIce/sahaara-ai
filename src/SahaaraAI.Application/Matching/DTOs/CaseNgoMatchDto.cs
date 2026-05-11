namespace SahaaraAI.Application.Matching.DTOs;

public class CaseNgoMatchDto
{
    public Guid Id { get; set; }
    public Guid CaseId { get; set; }
    public Guid NgoId { get; set; }
    public string? NgoName { get; set; }
    public int MatchScore { get; set; }
    public int Rank { get; set; }
    public string MatchReason { get; set; } = string.Empty;
    public bool IsSelectedForOutreach { get; set; }
    public bool IsLatest { get; set; }
    public MatchScoreBreakdownDto ScoreBreakdown { get; set; } = new();
}
