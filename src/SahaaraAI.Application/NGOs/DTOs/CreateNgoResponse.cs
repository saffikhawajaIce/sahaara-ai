namespace SahaaraAI.Application.NGOs.DTOs;

public class CreateNgoResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public NgoDto? Ngo { get; set; }
}
