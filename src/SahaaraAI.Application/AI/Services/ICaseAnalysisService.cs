using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Services;

public interface ICaseAnalysisService
{
    Task<CaseAnalysisResultDto> AnalyzeCaseAsync(Guid caseId);
    Task SaveReviewedAnalysisAsync(Guid caseId, CaseAnalysisResultDto reviewedResult);
}
