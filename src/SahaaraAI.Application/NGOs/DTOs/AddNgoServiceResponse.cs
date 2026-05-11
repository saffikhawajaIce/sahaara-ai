namespace SahaaraAI.Application.NGOs.DTOs;

public class AddNgoServiceResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public NgoServiceDto? Service { get; set; }
}
