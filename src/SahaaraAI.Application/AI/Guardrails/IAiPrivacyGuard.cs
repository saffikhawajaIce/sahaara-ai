namespace SahaaraAI.Application.AI.Guardrails;

public interface IAiPrivacyGuard
{
    string RedactSensitiveData(string input);
}
