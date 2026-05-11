using SahaaraAI.Application.Matching.DTOs;

namespace SahaaraAI.Application.Matching.Services;

public class NgoMatchingService : INgoMatchingService
{
    public Task<GenerateMatchesResponseDTO> GenerateMatchesAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }

    public Task<GetCaseMatchesResponseDTO> GetMatchesForCaseAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }

    public Task<SelectNgoForOutreachResponseDTO> SelectNgoForOutreachAsync(Guid caseId, Guid ngoId)
    {
        throw new NotImplementedException();
    }

    public Task<RegenerateMatchesResponseDTO> RegenerateMatchesAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }
}
