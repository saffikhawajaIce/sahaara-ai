using SahaaraAI.Application.AI.DTOs;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.AI.Services;

public class OutreachGenerationService : IOutreachGenerationService
{
    public Task<OutreachGenerationResultDto> GenerateOutreachDraftAsync(Guid caseId, Guid ngoId, CommunicationChannel channel)
    {
        throw new NotImplementedException();
    }
}
