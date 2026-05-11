using SahaaraAI.Application.FollowUps.DTOs;

namespace SahaaraAI.Application.FollowUps.Services;

public class FollowUpService : IFollowUpService
{
    public Task<CreateFollowUpResponseDTO> CreateFollowUpAsync(CreateFollowUpRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<GetDueFollowUpsResponseDTO> GetDueFollowUpsAsync(FollowUpSearchRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<CompleteFollowUpResponseDTO> CompleteFollowUpAsync(Guid followUpId, CompleteFollowUpRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<CancelFollowUpResponseDTO> CancelFollowUpAsync(Guid followUpId)
    {
        throw new NotImplementedException();
    }
}
