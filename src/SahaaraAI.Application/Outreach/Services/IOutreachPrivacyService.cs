namespace SahaaraAI.Application.Outreach.Services;

public interface IOutreachPrivacyService
{
    Task<bool> ValidateForSendingAsync(Guid outreachId);
    bool ContainsSensitiveData(string message);
    string RemoveSensitiveData(string message);
}
