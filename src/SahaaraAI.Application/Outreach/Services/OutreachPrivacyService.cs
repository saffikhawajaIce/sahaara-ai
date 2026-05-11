namespace SahaaraAI.Application.Outreach.Services;

public class OutreachPrivacyService : IOutreachPrivacyService
{
    public Task<bool> ValidateForSendingAsync(Guid outreachId)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSensitiveData(string message)
    {
        throw new NotImplementedException();
    }

    public string RemoveSensitiveData(string message)
    {
        return message;
    }
}
