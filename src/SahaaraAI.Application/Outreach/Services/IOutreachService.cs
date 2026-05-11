using SahaaraAI.Application.Outreach.DTOs;

namespace SahaaraAI.Application.Outreach.Services;

public interface IOutreachService
{
    Task<CreateOutreachDraftResponseDTO> CreateDraftAsync(CreateOutreachDraftRequestDTO request);
    Task<GetOutreachResponseDTO> GetOutreachByIdAsync(Guid outreachId);
    Task<GetCaseOutreachResponseDTO> GetOutreachForCaseAsync(Guid caseId);
    Task<UpdateOutreachDraftResponseDTO> UpdateDraftAsync(Guid outreachId, UpdateOutreachDraftRequestDTO request);
    Task<SendOutreachResponseDTO> SendEmailAsync(Guid outreachId);
    Task<LogManualOutreachResponseDTO> LogManualOutreachAsync(Guid outreachId, SendOutreachRequestDTO request);
}
