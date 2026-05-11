using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Guardrails;

public interface IAiOutputValidator
{
    bool IsValidCaseAnalysisResult(CaseAnalysisResultDto result);
    bool IsValidOutreachResult(OutreachGenerationResultDto result);
    bool IsValidFollowUpResult(FollowUpGenerationResultDto result);
}
