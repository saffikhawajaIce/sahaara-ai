using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Matching.Services;

public interface IMatchReasonBuilder
{
    string BuildReason(AssistanceCase assistanceCase, Ngo ngo, NgoService service, int score);
}
