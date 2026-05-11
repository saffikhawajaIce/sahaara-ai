using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Prompting;

public interface IAiPromptBuilder
{
    string BuildCaseAnalysisPrompt(AnalyzeCaseRequestDTO request);
    string BuildOutreachPrompt(GenerateOutreachRequestDTO request);
    string BuildFollowUpPrompt(GenerateFollowUpRequestDTO request);
}
