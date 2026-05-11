using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Matching.Services;

public class MatchScoringService : IMatchScoringService
{
    public int CalculateScore(AssistanceCase assistanceCase, Ngo ngo, NgoService service)
    {
        var score = 0;

        if (assistanceCase.CategoryId.HasValue && assistanceCase.CategoryId == service.CategoryId)
        {
            score += 50;
        }

        if (assistanceCase.SubcategoryId.HasValue &&
            service.SubcategoryId.HasValue &&
            assistanceCase.SubcategoryId == service.SubcategoryId)
        {
            score += 20;
        }

        if (string.Equals(assistanceCase.City, ngo.City, StringComparison.OrdinalIgnoreCase))
        {
            score += 20;
        }

        if (string.Equals(assistanceCase.Area, ngo.Area, StringComparison.OrdinalIgnoreCase))
        {
            score += 10;
        }

        return score;
    }
}
