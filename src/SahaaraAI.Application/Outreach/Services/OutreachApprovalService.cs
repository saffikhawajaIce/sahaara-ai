using SahaaraAI.Application.Outreach.DTOs;

namespace SahaaraAI.Application.Outreach.Services;

public class OutreachApprovalService : IOutreachApprovalService
{
    public Task<ApproveOutreachResponseDTO> ApproveAsync(Guid outreachId, ApproveOutreachRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<RejectOutreachResponseDTO> RejectAsync(Guid outreachId, string reason)
    {
        throw new NotImplementedException();
    }
}
