using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.AI.Services;

public interface IFollowUpGenerationService
{
    Task<FollowUpGenerationResultDto> GenerateFollowUpAsync(Guid outreachMessageId);
}
