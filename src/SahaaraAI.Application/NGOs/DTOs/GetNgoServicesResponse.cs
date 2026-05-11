namespace SahaaraAI.Application.NGOs.DTOs;

public class GetNgoServicesResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<NgoServiceDto> Services { get; set; } = [];
}
