using SahaaraAI.Application.AI.DTOs;
using SahaaraAI.Application.Common.Interfaces.AI;

namespace SahaaraAI.Infrastructure.AI;

public class OpenAiFollowUpProvider : IAiFollowUpProvider
{
    public Task<FollowUpGenerationResultDto> GenerateFollowUpAsync(AiFollowUpInput input)
    {
        throw new NotImplementedException();
    }
}
