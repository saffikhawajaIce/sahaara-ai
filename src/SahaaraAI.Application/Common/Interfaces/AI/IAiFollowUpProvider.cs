using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.Common.Interfaces.AI;

public interface IAiFollowUpProvider
{
    Task<FollowUpGenerationResultDto> GenerateFollowUpAsync(AiFollowUpInput input);
}
