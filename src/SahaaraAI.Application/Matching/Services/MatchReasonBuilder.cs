using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Matching.Services;

public class MatchReasonBuilder : IMatchReasonBuilder
{
    public string BuildReason(AssistanceCase assistanceCase, Ngo ngo, NgoService service, int score)
    {
        var reasons = new List<string>();

        if (assistanceCase.CategoryId.HasValue && assistanceCase.CategoryId == service.CategoryId)
        {
            reasons.Add("category match");
        }

        if (assistanceCase.SubcategoryId.HasValue &&
            service.SubcategoryId.HasValue &&
            assistanceCase.SubcategoryId == service.SubcategoryId)
        {
            reasons.Add("subcategory match");
        }

        if (string.Equals(assistanceCase.City, ngo.City, StringComparison.OrdinalIgnoreCase))
        {
            reasons.Add("same city");
        }

        if (string.Equals(assistanceCase.Area, ngo.Area, StringComparison.OrdinalIgnoreCase))
        {
            reasons.Add("same area");
        }

        if (reasons.Count == 0)
        {
            reasons.Add("baseline compatibility");
        }

        return $"Score {score}: {string.Join(", ", reasons)}.";
    }
}
