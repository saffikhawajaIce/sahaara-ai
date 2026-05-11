namespace SahaaraAI.Application.NGOs.DTOs;

public class ReactivateNgoResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public Guid NgoId { get; set; }
}
