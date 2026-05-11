using SahaaraAI.Application.Outreach.DTOs;

namespace SahaaraAI.Application.Outreach.Services;

public class OutreachService : IOutreachService
{
    public Task<CreateOutreachDraftResponseDTO> CreateDraftAsync(CreateOutreachDraftRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<GetOutreachResponseDTO> GetOutreachByIdAsync(Guid outreachId)
    {
        throw new NotImplementedException();
    }

    public Task<GetCaseOutreachResponseDTO> GetOutreachForCaseAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateOutreachDraftResponseDTO> UpdateDraftAsync(Guid outreachId, UpdateOutreachDraftRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<SendOutreachResponseDTO> SendEmailAsync(Guid outreachId)
    {
        throw new NotImplementedException();
    }

    public Task<LogManualOutreachResponseDTO> LogManualOutreachAsync(Guid outreachId, SendOutreachRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
