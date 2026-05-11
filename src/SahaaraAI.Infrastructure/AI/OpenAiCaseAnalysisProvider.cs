using SahaaraAI.Application.AI.DTOs;
using SahaaraAI.Application.Common.Interfaces.AI;

namespace SahaaraAI.Infrastructure.AI;

public class OpenAiCaseAnalysisProvider : IAiCaseAnalysisProvider
{
    public Task<CaseAnalysisResultDto> AnalyzeCaseAsync(AiCaseAnalysisInput input)
    {
        throw new NotImplementedException();
    }
}
