using SahaaraAI.Application.FollowUps.DTOs;

namespace SahaaraAI.Application.FollowUps.Services;

public interface IFollowUpService
{
    Task<CreateFollowUpResponseDTO> CreateFollowUpAsync(CreateFollowUpRequestDTO request);
    Task<GetDueFollowUpsResponseDTO> GetDueFollowUpsAsync(FollowUpSearchRequestDTO request);
    Task<CompleteFollowUpResponseDTO> CompleteFollowUpAsync(Guid followUpId, CompleteFollowUpRequestDTO request);
    Task<CancelFollowUpResponseDTO> CancelFollowUpAsync(Guid followUpId);
}
