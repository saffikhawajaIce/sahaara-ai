using SahaaraAI.Application.Cases.DTOs;

namespace SahaaraAI.Application.Cases.Services;

public interface ICaseNoteService
{
    Task<AddCaseNoteResponseDTO> AddNoteAsync(Guid caseId, AddCaseNoteRequestDTO request);
}
