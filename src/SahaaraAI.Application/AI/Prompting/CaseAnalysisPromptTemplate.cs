using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Prompting;

public static class CaseAnalysisPromptTemplate
{
    public static string Build(AnalyzeCaseRequestDTO request)
    {
        return
            $"Analyze this assistance case.{Environment.NewLine}" +
            $"CaseId: {request.CaseId}{Environment.NewLine}" +
            $"Title: {request.Title}{Environment.NewLine}" +
            $"Description: {request.RawDescription}{Environment.NewLine}" +
            $"RequiredHelp: {request.RequiredHelp}{Environment.NewLine}" +
            $"Location: {request.Area}, {request.City}";
    }
}
