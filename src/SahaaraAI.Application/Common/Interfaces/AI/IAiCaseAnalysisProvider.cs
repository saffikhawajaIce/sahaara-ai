using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.Common.Interfaces.AI;

public interface IAiCaseAnalysisProvider
{
    Task<CaseAnalysisResultDto> AnalyzeCaseAsync(AiCaseAnalysisInput input);
}
