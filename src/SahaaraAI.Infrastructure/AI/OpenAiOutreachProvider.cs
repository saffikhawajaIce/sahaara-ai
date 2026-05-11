using SahaaraAI.Application.AI.DTOs;
using SahaaraAI.Application.Common.Interfaces.AI;

namespace SahaaraAI.Infrastructure.AI;

public class OpenAiOutreachProvider : IAiOutreachProvider
{
    public Task<OutreachGenerationResultDto> GenerateOutreachAsync(AiOutreachInput input)
    {
        throw new NotImplementedException();
    }
}
