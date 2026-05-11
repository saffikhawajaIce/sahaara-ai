using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Prompting;

public static class FollowUpPromptTemplate
{
    public static string Build(GenerateFollowUpRequestDTO request)
    {
        return
            $"Generate a follow-up message.{Environment.NewLine}" +
            $"OutreachMessageId: {request.OutreachMessageId}{Environment.NewLine}" +
            $"PreviousMessageBody: {request.PreviousMessageBody}{Environment.NewLine}" +
            $"LastResponseSummary: {request.LastResponseSummary}{Environment.NewLine}" +
            $"Instructions: {request.AdditionalInstructions}";
    }
}
