using SahaaraAI.Application.Cases.DTOs;

namespace SahaaraAI.Application.Cases.Services;

public class CaseNoteService : ICaseNoteService
{
    public Task<AddCaseNoteResponseDTO> AddNoteAsync(Guid caseId, AddCaseNoteRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
