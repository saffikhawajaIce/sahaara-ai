using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Prompting;

public class AiPromptBuilder : IAiPromptBuilder
{
    public string BuildCaseAnalysisPrompt(AnalyzeCaseRequestDTO request)
    {
        return CaseAnalysisPromptTemplate.Build(request);
    }

    public string BuildOutreachPrompt(GenerateOutreachRequestDTO request)
    {
        return OutreachPromptTemplate.Build(request);
    }

    public string BuildFollowUpPrompt(GenerateFollowUpRequestDTO request)
    {
        return FollowUpPromptTemplate.Build(request);
    }
}
