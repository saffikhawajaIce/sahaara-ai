using SahaaraAI.Application.AI.DTOs;
using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.AI.Services;

public interface IOutreachGenerationService
{
    Task<OutreachGenerationResultDto> GenerateOutreachDraftAsync(Guid caseId, Guid ngoId, CommunicationChannel channel);
}
