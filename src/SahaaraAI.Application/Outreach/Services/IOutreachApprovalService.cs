using SahaaraAI.Application.Outreach.DTOs;

namespace SahaaraAI.Application.Outreach.Services;

public interface IOutreachApprovalService
{
    Task<ApproveOutreachResponseDTO> ApproveAsync(Guid outreachId, ApproveOutreachRequestDTO request);
    Task<RejectOutreachResponseDTO> RejectAsync(Guid outreachId, string reason);
}
