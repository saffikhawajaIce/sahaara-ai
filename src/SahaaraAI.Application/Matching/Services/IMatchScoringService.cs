using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Matching.Services;

public interface IMatchScoringService
{
    int CalculateScore(AssistanceCase assistanceCase, Ngo ngo, NgoService service);
}
