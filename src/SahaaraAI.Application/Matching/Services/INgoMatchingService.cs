using SahaaraAI.Application.Matching.DTOs;

namespace SahaaraAI.Application.Matching.Services;

public interface INgoMatchingService
{
    Task<GenerateMatchesResponseDTO> GenerateMatchesAsync(Guid caseId);
    Task<GetCaseMatchesResponseDTO> GetMatchesForCaseAsync(Guid caseId);
    Task<SelectNgoForOutreachResponseDTO> SelectNgoForOutreachAsync(Guid caseId, Guid ngoId);
    Task<RegenerateMatchesResponseDTO> RegenerateMatchesAsync(Guid caseId);
}
