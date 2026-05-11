using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Prompting;

public static class OutreachPromptTemplate
{
    public static string Build(GenerateOutreachRequestDTO request)
    {
        return
            $"Generate an outreach draft.{Environment.NewLine}" +
            $"CaseId: {request.CaseId}{Environment.NewLine}" +
            $"NgoId: {request.NgoId}{Environment.NewLine}" +
            $"Channel: {request.Channel}{Environment.NewLine}" +
            $"Instructions: {request.AdditionalInstructions}";
    }
}
