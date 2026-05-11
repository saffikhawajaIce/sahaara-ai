using SahaaraAI.Application.Cases.DTOs;

namespace SahaaraAI.Application.Cases.Services;

public interface ICaseService
{
    public Task<CreateCaseResponseDTO> CreateCaseAsync(CreateCaseRequestDTO request);
    public Task<GetCaseResponseDTO> GetCaseByIdAsync(Guid caseId);
    public Task<SearchCasesResponseDTO> SearchCasesAsync();
    public Task<UpdateCaseResponseDTO> UpdateCaseAsync(Guid caseId, UpdateCaseRequestDTO request);
    public Task<CloseCaseResponseDTO> CloseCaseAsync(Guid caseId, CloseCaseRequestDTO request);
    public Task<ReopenCaseResponseDTO> ReopenCaseAsync(Guid caseId, ReopenCaseRequestDTO request);
}
