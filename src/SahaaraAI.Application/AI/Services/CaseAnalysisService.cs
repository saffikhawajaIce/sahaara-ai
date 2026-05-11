using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Services;

public class CaseAnalysisService : ICaseAnalysisService
{
    public Task<CaseAnalysisResultDto> AnalyzeCaseAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }

    public Task SaveReviewedAnalysisAsync(Guid caseId, CaseAnalysisResultDto reviewedResult)
    {
        throw new NotImplementedException();
    }
}
