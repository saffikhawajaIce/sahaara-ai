using SahaaraAI.Application.Applicants.DTOs;

namespace SahaaraAI.Application.Applicants.Services;

public class ConsentService : IConsentService
{
    public Task RecordConsentAsync(Guid applicantId, UpdateConsentRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConsentRecordDto>> GetConsentHistoryAsync(Guid applicantId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasValidConsentAsync(Guid applicantId)
    {
        throw new NotImplementedException();
    }
}
