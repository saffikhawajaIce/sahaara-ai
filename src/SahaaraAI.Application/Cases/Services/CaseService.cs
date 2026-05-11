using SahaaraAI.Application.Cases.DTOs;

namespace SahaaraAI.Application.Cases.Services;

public class CaseService : ICaseService
{
    public Task<CreateCaseResponseDTO> CreateCaseAsync(CreateCaseRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<GetCaseResponseDTO> GetCaseByIdAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }

    public Task<SearchCasesResponseDTO> SearchCasesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdateCaseResponseDTO> UpdateCaseAsync(Guid caseId, UpdateCaseRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<CloseCaseResponseDTO> CloseCaseAsync(Guid caseId, CloseCaseRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<ReopenCaseResponseDTO> ReopenCaseAsync(Guid caseId, ReopenCaseRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
