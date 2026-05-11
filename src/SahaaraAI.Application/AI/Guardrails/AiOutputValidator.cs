using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Guardrails;

public class AiOutputValidator : IAiOutputValidator
{
    public bool IsValidCaseAnalysisResult(CaseAnalysisResultDto result)
    {
        return !string.IsNullOrWhiteSpace(result.Summary);
    }

    public bool IsValidOutreachResult(OutreachGenerationResultDto result)
    {
        return !string.IsNullOrWhiteSpace(result.Body);
    }

    public bool IsValidFollowUpResult(FollowUpGenerationResultDto result)
    {
        return !string.IsNullOrWhiteSpace(result.Message);
    }
}
