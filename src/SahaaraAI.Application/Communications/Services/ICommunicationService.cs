using SahaaraAI.Application.Communications.DTOs;

namespace SahaaraAI.Application.Communications.Services;

public interface ICommunicationService
{
    Task<AddCommunicationLogResponseDTO> AddLogAsync(AddCommunicationLogRequestDTO request);
    Task<UpdateNgoResponseResponseDTO> UpdateNgoResponseAsync(Guid communicationLogId, UpdateNgoResponseRequestDTO request);
    Task<GetCommunicationTimelineResponseDTO> GetCommunicationTimelineAsync(Guid caseId);
}
