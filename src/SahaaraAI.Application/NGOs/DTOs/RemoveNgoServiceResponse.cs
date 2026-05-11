namespace SahaaraAI.Application.NGOs.DTOs;

public class RemoveNgoServiceResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public Guid NgoServiceId { get; set; }
}
