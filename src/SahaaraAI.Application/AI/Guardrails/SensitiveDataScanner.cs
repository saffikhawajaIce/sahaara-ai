namespace SahaaraAI.Application.AI.Guardrails;

public class SensitiveDataScanner : ISensitiveDataScanner
{
    public bool ContainsSensitiveData(string input)
    {
        return false;
    }
}
