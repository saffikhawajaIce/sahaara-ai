using SahaaraAI.Application.Communications.DTOs;

namespace SahaaraAI.Application.Communications.Services;

public class CommunicationService : ICommunicationService
{
    public Task<AddCommunicationLogResponseDTO> AddLogAsync(AddCommunicationLogRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateNgoResponseResponseDTO> UpdateNgoResponseAsync(Guid communicationLogId, UpdateNgoResponseRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<GetCommunicationTimelineResponseDTO> GetCommunicationTimelineAsync(Guid caseId)
    {
        throw new NotImplementedException();
    }
}
