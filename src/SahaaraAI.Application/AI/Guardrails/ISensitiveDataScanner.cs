namespace SahaaraAI.Application.AI.Guardrails;

public interface ISensitiveDataScanner
{
    bool ContainsSensitiveData(string input);
}
