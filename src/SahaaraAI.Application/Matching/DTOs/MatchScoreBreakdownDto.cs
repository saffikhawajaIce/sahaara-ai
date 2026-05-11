namespace SahaaraAI.Application.Matching.DTOs;

public class MatchScoreBreakdownDto
{
    public int CategoryMatchScore { get; set; }
    public int SubcategoryMatchScore { get; set; }
    public int SameCityScore { get; set; }
    public int SameAreaScore { get; set; }
    public int TotalScore { get; set; }
}
