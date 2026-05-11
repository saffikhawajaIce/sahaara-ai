using SahaaraAI.Application.AI.DTOs;

namespace SahaaraAI.Application.Common.Interfaces.AI;

public interface IAiOutreachProvider
{
    Task<OutreachGenerationResultDto> GenerateOutreachAsync(AiOutreachInput input);
}
