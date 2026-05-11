using SahaaraAI.Application.AI.DTOs;
using SahaaraAI.Application.Common.Interfaces.AI;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Infrastructure.AI;

public class FakeAiProvider : IAiCaseAnalysisProvider, IAiOutreachProvider, IAiFollowUpProvider
{
    public Task<CaseAnalysisResultDto> AnalyzeCaseAsync(AiCaseAnalysisInput input)
    {
        return Task.FromResult(new CaseAnalysisResultDto
        {
            Summary = $"Fake analysis for case {input.CaseId}",
            RequiredSupportJson = "[]",
            SuggestedDocumentsJson = "[]",
            SensitivityLevel = "Low",
            ReviewStatus = AiReviewStatus.Generated
        });
    }

    public Task<OutreachGenerationResultDto> GenerateOutreachAsync(AiOutreachInput input)
    {
        return Task.FromResult(new OutreachGenerationResultDto
        {
            Subject = $"Assistance Request for Case {input.CaseId}",
            Body = $"This is a fake outreach draft for NGO {input.NgoId}.",
            Channel = input.Channel
        });
    }

    public Task<FollowUpGenerationResultDto> GenerateFollowUpAsync(AiFollowUpInput input)
    {
        return Task.FromResult(new FollowUpGenerationResultDto
        {
            Message = $"This is a fake follow-up for outreach {input.OutreachMessageId}.",
            SuggestedSendAt = DateTime.UtcNow.AddDays(1)
        });
    }
}
